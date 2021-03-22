using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using MySql.Data.MySqlClient;

namespace frm_trabalho_interdisciplinar
{
    class ConexaoBD
    {
        private MySqlConnection conexao;

        public void ConectarBD()
        {
            try
            {
                conexao = new MySqlConnection("Persist Security info = false;server=localhost;database=MESADINHA;user=root;pwd=");
                conexao.Open();
            }
            catch
            {
                throw;
            }
        }
        public int Alterartabelas(string sql)
        {
            try
            {
                ConectarBD();
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                return cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                conexao.Close();
            }
        }
        public DataTable consultardados(string sql)
        {
            try
            {
                ConectarBD();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conexao);
                da.Fill(dt);
                return dt;
            }
            catch
            {
                throw;
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
