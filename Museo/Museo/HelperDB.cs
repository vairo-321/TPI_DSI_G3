using Museo.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museo
{
    public class HelperDB
    {
        private string cadenaConexion = @"Data Source=(localdb)\tomyserver;Initial Catalog=MuseoBD;Integrated Security=True";
        public SqlConnection cn;
        private SqlCommandBuilder cmb;
        public DataSet ds = new DataSet();
        public SqlDataAdapter da;
        public SqlCommand comando;
        public SqlCommand comandoDetalle;
        public DataTable dt;
        public SqlTransaction objTransaccion;

        private void conectar()
        {
            cn = new SqlConnection(cadenaConexion);
        }

        public HelperDB()
        {
            conectar();
        }

        public DataTable ObtenerDatos(string sql)
        {
            try
            {
                //string sql = "select * from ";
                da = new SqlDataAdapter(sql, cn);
                DataSet dts = new DataSet();
                da.Fill(dts, "resultado");
                DataTable dt = new DataTable();
                dt = dts.Tables["resultado"];
                return dt;
            }
            finally
            {
                cn.Close();
            }
        }

        public bool Insertar(string sql)
        {
            cn.Open();
            comando = new SqlCommand(sql, cn);
            int i = comando.ExecuteNonQuery();
            cn.Close();

            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int ObtenerUltimo()
        {
            cn.Open();
            try
            {
                string sql = "SELECT MAX(numero) FROM T_Entrada";
                comando = new SqlCommand(sql, cn);
                int resultado = (int)comando.ExecuteScalar();

                return resultado;
            }
            catch (Exception ex)
            {
                return 0;
                throw ex;
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
