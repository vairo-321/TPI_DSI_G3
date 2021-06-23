using Museo.Interfaz;
using Museo.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museo.Controladores
{
    public class GestorRegistroVentaEntrada
    {
        HelperDB helper = new HelperDB();
        Sede sede = new Sede();
        Entrada[] entrada;
        ReservaVisita[] reservaVisita;

        Sesion sesionActual = new Sesion();

        int numSedeAct;
        int cantEnSede;
        int cantMaxVisitantes;

        public void inicioSesio()
        {
            sesionActual.usuario = new Usuario();
            sesionActual.usuario.empleado = new Empleado();
            sesionActual.usuario.empleado.sedeDondeTrabaja = new Sede();
            sesionActual.usuario.empleado.sedeDondeTrabaja.numero = 1;
        }
        public void buscarSedeActual()
        {
            numSedeAct = sesionActual.conocerUsuario();
        }
        public void opcionRegistrarEntrada()
        {
            inicioSesio();
            buscarSedeActual();
            string sql = "SELECT S.*, T.*, E.nombre AS TipoEntrada, V.nombre AS TipoVisita FROM T_Sede S " +
                "INNER JOIN T_Tarifa_X_Sede ts ON ts.idSede = s.idSede " +
                "INNER JOIN T_Tarifa T ON ts.idTarifa = T.idTarifa " +
                "INNER JOIN T_Tipo_Entrada E ON T.idTipoEntrada = E.id " +
                "INNER JOIN T_Tipo_Visita V ON T.idTipoVisita = V.id " +
                "WHERE S.idSede = " + numSedeAct + "; "; 

            DataTable tb = new DataTable();
            tb = helper.ObtenerDatos(sql);

            sede.tarifa = new Tarifa[tb.Rows.Count];

            for (int i = 0; i < tb.Rows.Count; i++)
            {
                sede.numero = Convert.ToInt32(tb.Rows[i]["idSede"].ToString());
                sede.nombre = tb.Rows[i]["nombre"].ToString();
                sede.cantMaximaVisitantes = (int)tb.Rows[i]["cantMaximaVisitantes"];
                sede.cantMaxPorGuia = (int)tb.Rows[i]["cantMaxPorGuia"];
                sede.tarifa[i] = new Tarifa();
                sede.tarifa[i].idTarifa = int.Parse(tb.Rows[i]["idTarifa"].ToString());
                sede.tarifa[i].fechaInicioVigencia = DateTime.Parse(tb.Rows[i]["fechaInicioVigencia"].ToString());
                sede.tarifa[i].fechaFinVigencia = DateTime.Parse(tb.Rows[i]["fechaFinVigencia"].ToString());
                sede.tarifa[i].monto = int.Parse(tb.Rows[i]["monto"].ToString());
                sede.tarifa[i].montoAdicionalGuia = (tb.Rows[i]["montoAdicionalGuia"].ToString() != "          ") ? int.Parse(tb.Rows[i]["montoAdicionalGuia"].ToString()) : 0;

                sede.tarifa[i].tipoEntrada = new TipoDeEntrada();
                sede.tarifa[i].tipoVisita = new TipoVisita();
                
                sede.tarifa[i].tipoEntrada.nombre = tb.Rows[i]["TipoEntrada"].ToString();
                sede.tarifa[i].tipoVisita.nombre = tb.Rows[i]["TipoVisita"].ToString();
            }
        }
        public DateTime getFechaActual()
        {
            return DateTime.Now;
        }

        public object[,] buscarTarifasSedeActual()
        {
            opcionRegistrarEntrada();
            return sede.getTarifa(getFechaActual());
        }

        public string  tomarSeleccionTarifa(string tipoVis)
        {
            buscarExposiciones(tipoVis);
            return calcularDuracionAExposicionesVigentes();
        }

        public string calcularDuracionAExposicionesVigentes()
        {
            DateTime[] obj = sede.calcularDuracionAExposicionesVigentes(getFechaActual());

            string hora = obj[0].Hour.ToString().Length == 1 ? "0" + obj[0].Hour.ToString() : obj[0].Hour.ToString();
            string minutos = obj[0].Minute.ToString().Length == 1 ? "0" + obj[0].Minute.ToString() : obj[0].Minute.ToString();
            string segundos = obj[0].Second.ToString().Length == 1 ? "0" + obj[0].Second.ToString() : obj[0].Second.ToString();


            return  hora + ":" + minutos + ":" + segundos;
        }

        public int[] tomarCantidadEntradas(int cantEntradas, TimeSpan duracion, int monto)
        {
            int[] detalle = new int[3];
            buscarReservasYEntradas();
            if (validarCantidadEntradas(cantEntradas, duracion))
            {
                detalle[0] = cantEntradas;
                detalle[1] = monto;
                detalle[2] = calcularMontoTotal(cantEntradas, monto);
            }
            return detalle;
        }

        public bool validarCantidadEntradas(int cantEntradas, TimeSpan duracion)
        {
            int cantEntradasActual = 0;
            int cantAlumnosReserva = sede.calcularCantidadReservada(reservaVisita, getFechaActual(), duracion);

            for (int i = 0; i < entrada.Length; i++)
            {
                if (entrada[i].esDeSedeActual(sede.numero) && entrada[i].esDeFechaHora(getFechaActual()))
                {
                    cantEntradasActual += 1;
                }
            }

            cantEnSede = cantAlumnosReserva + cantEntradasActual;
            cantMaxVisitantes = sede.getCantMaximaVisitantes();

            return esMenorCantidadVisitantes(cantEntradas, cantEnSede, cantMaxVisitantes);
        }

        public bool esMenorCantidadVisitantes(int cantEntradas, int cantEnSede, int cantMaxima)
        {
            if (cantEntradas <= (cantMaxima - cantEnSede))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int calcularMontoTotal(int cantEntradas, int monto)
        {
            return cantEntradas * monto;
        }

        public void tomarConfirmacionVenta(int cantEntradas, int monto, int idTarifa, string tipoEntrada, string tipoVisita, int montoAd, DateTime fechaIni, DateTime fechaFin)
        {
            registrarEntradas(cantEntradas, monto, idTarifa);
            int numeroEntrada = helper.ObtenerUltimo() - (cantEntradas - 1);
            entrada = new Entrada[cantEntradas];
            for (int i = 0; i < cantEntradas; i++)
            {
                entrada[i] = new Entrada();
                entrada[i].numero = numeroEntrada + i;
                entrada[i].monto = monto;
                entrada[i].tarifa = new Tarifa();
                entrada[i].tarifa.idTarifa = idTarifa;
                entrada[i].tarifa.monto = monto;
                entrada[i].tarifa.montoAdicionalGuia = montoAd;
                entrada[i].tarifa.fechaInicioVigencia = fechaIni;
                entrada[i].tarifa.fechaFinVigencia = fechaFin;
                entrada[i].tarifa.tipoEntrada = new TipoDeEntrada();
                entrada[i].tarifa.tipoEntrada.nombre = tipoEntrada;
                entrada[i].tarifa.tipoVisita = new TipoVisita();
                entrada[i].tarifa.tipoVisita.nombre = tipoVisita;

                imprimirEntrada((buscarUltimaEntrada(i)).ToString(), monto.ToString());
            }

            actualizarCantidadVisitantes(cantEntradas);
        }

        public void registrarEntradas(int cantEntradas, int monto, int idTarifa)
        {
            string sql = "INSERT INTO T_Entrada (fechaVenta, horaVenta, monto, idSede, idTarifa) " +
                "VALUES(GETDATE(), CONVERT(time, GETDATE()), " + monto + ", " + sede.numero + ", " + idTarifa + ")";

            for (int i = 0; i < cantEntradas; i++)
            {
                helper.Insertar(sql);
            }
        }

        public int buscarUltimaEntrada(int indice)
        {
            int ultimoNumero = entrada[indice].getNumero();

            return ultimoNumero;
        }

        public void imprimirEntrada(string numeroEntrada, string monto)
        {
            Impresora impresora = new Impresora();
            impresora.imprimir(numeroEntrada, monto);
            impresora.Show();
        }

        public void actualizarCantidadVisitantes(int cantEntradas)
        {
            PantallaEntrada pantalla = new PantallaEntrada();
            pantalla.actualizarPantalla(cantEnSede + cantEntradas, cantMaxVisitantes);
            pantalla.Show();
        }

        public void buscarExposiciones(string condicion)
        {
            string sql = "SELECT DISTINCT e.fechaInicio, " +
                "e.fechaFin, " +
                "e.fechaInicioReplanificada, " +
                "e.fechaFinReplanificada, " +
                "o.duracionResumida " +
                "FROM T_Sede S " +
                "INNER JOIN T_Tarifa_X_Sede ts ON ts.idSede = s.idSede " +
                "INNER JOIN T_Tarifa T ON ts.idTarifa = T.idTarifa " +
                "INNER JOIN T_Tipo_Visita TV ON T.idTipoVisita = TV.id " +
                "INNER JOIN T_ExposicionXSede ES ON S.idSede = ES.idSede " +
                "INNER JOIN T_Exposicion E ON E.id = ES.idExposicion " +
                "INNER JOIN T_Detalle_Exposicion D ON D.idExposicion = E.id " +
                "INNER JOIN T_Obra O ON D.idObra = O.id " +
                "WHERE TV.nombre = '" + condicion + "' and s.idSede = " + numSedeAct + "; ";

            DataTable tb = new DataTable();
            tb = helper.ObtenerDatos(sql);

            sede.exposicion = new Exposicion[tb.Rows.Count];
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                sede.exposicion[i] = new Exposicion();
                sede.exposicion[i].fechaInicio = DateTime.Parse(tb.Rows[i]["fechaInicio"].ToString());
                //sede.exposicion[i].fechaInicioReplanificada = DateTime.Parse(tb.Rows[i]["fechaInicioReplanificada"].ToString());
                sede.exposicion[i].fechaFin = DateTime.Parse(tb.Rows[i]["fechaFin"].ToString());
                //sede.exposicion[i].fechaFinReplanificada = DateTime.Parse(tb.Rows[i]["fechaFinReplanificada"].ToString());

                sede.exposicion[i].detalle = new DetalleExposicion[tb.Rows.Count];
                for (int j = 0; j < tb.Rows.Count; j++)
                {
                    sede.exposicion[i].detalle[j] = new DetalleExposicion();
                    sede.exposicion[i].detalle[j].obra = new Obra();
                    sede.exposicion[i].detalle[j].obra.duracionResumida = DateTime.Parse(tb.Rows[j]["duracionResumida"].ToString());
                }
            }
        }

        public void buscarReservasYEntradas()
        {
            string sql = "SELECT * FROM T_Reserva_Visita R WHERE R.idSede = " + numSedeAct + "; ";

            string sql2 = "SELECT * FROM T_Entrada E WHERE E.idSede = " + numSedeAct + "; ";

            DataTable tb = new DataTable();
            tb = helper.ObtenerDatos(sql);

            DataTable tb2 = new DataTable();
            tb2 = helper.ObtenerDatos(sql2);

            reservaVisita = new ReservaVisita[tb.Rows.Count];
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                reservaVisita[i] = new ReservaVisita();
                reservaVisita[i].cantidadAlumnos = Convert.ToInt32(tb.Rows[i]["cantidadAlumnos"].ToString());
                reservaVisita[i].cantidadAlumnosConfirmada = Convert.ToInt32(tb.Rows[i]["cantidadAlumnosConfirmada"].ToString());
                reservaVisita[i].duracionEstimada = TimeSpan.FromTicks(Convert.ToDateTime(tb.Rows[i]["duracionEstimada"].ToString()).Ticks);
                reservaVisita[i].fechaHoraCreacion = Convert.ToDateTime(tb.Rows[i]["fechaHoraCreacion"].ToString());
                reservaVisita[i].fechaHoraReserva = Convert.ToDateTime(tb.Rows[i]["fechaHoraReserva"].ToString());
                reservaVisita[i].horaFinReal = TimeSpan.FromTicks(Convert.ToDateTime(tb.Rows[i]["horaFinReal"].ToString()).Ticks);
                reservaVisita[i].horaInicioReal = TimeSpan.FromTicks(Convert.ToDateTime(tb.Rows[i]["horaFinReal"].ToString()).Ticks);
                reservaVisita[i].sede = new Sede();
                reservaVisita[i].sede.numero = Convert.ToInt32(tb.Rows[i]["idSede"].ToString());
            }

            entrada = new Entrada[tb2.Rows.Count];
            for (int j = 0; j < tb2.Rows.Count; j++)
            {
                entrada[j] = new Entrada();
                entrada[j].numero = Convert.ToInt32(tb2.Rows[j]["numero"].ToString());
                entrada[j].fechaVenta = Convert.ToDateTime(tb2.Rows[j]["fechaVenta"].ToString());
                entrada[j].horaVenta = TimeSpan.FromTicks(Convert.ToDateTime(tb2.Rows[j]["horaVenta"].ToString()).Ticks);
                entrada[j].monto = Convert.ToInt32(tb2.Rows[j]["monto"].ToString());
                entrada[j].sede = new Sede();
                entrada[j].sede.numero = Convert.ToInt32(tb2.Rows[j]["idSede"].ToString());
            }
        }

        public void actualizarEntradas()
        {
            string sql2 = "SELECT * FROM T_Entrada E WHERE E.idSede = " + numSedeAct + "; ";

            DataTable tb2 = new DataTable();
            tb2 = helper.ObtenerDatos(sql2);

            entrada = new Entrada[tb2.Rows.Count];
            for (int j = 0; j < tb2.Rows.Count; j++)
            {
                entrada[j] = new Entrada();
                entrada[j].numero = Convert.ToInt32(tb2.Rows[j]["numero"].ToString());
                entrada[j].fechaVenta = Convert.ToDateTime(tb2.Rows[j]["fechaVenta"].ToString());
                entrada[j].horaVenta = TimeSpan.FromTicks(Convert.ToDateTime(tb2.Rows[j]["horaVenta"].ToString()).Ticks);
                entrada[j].monto = Convert.ToInt32(tb2.Rows[j]["monto"].ToString());
                entrada[j].sede = new Sede();
                entrada[j].sede.numero = Convert.ToInt32(tb2.Rows[j]["idSede"].ToString());
            }
        }
    }
}
