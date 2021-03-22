using System.Data;


namespace frm_trabalho_interdisciplinar
{
    class Login
    {
        public bool validarusuario(string usuario, string senha)
        {
            ConexaoBD bd = new ConexaoBD();
            string sql = string.Format("select * from USUARIO where email = '{0}' and senha = '{1}'"
                ,usuario,senha);
            DataTable resultado = new DataTable();
            resultado = bd.consultardados(sql);
            if (resultado.Rows.Count > 0)           
                return true;            
            else
                return false;
            
        }
    }
}
