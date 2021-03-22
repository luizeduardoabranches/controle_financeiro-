using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frm_trabalho_interdisciplinar
{
    public partial class frm_alterar_senha : Form
    {
        string x_email;
        public frm_alterar_senha(string _email)
        {
            InitializeComponent();
            if (_email != "")
                x_email = _email;
        }   
        public void limpar()
        {
            txt_senha_alterada.Clear();
        }

        ConexaoBD bd = new ConexaoBD();
       
        private void frm_alterar_senha_Load(object sender, EventArgs e)
        {
            

           

        }

        private void btn_alterar_senha_Click(object sender, EventArgs e)
        {
            DataTable resultado_id = new DataTable();
            var sql_id = $"select ID from USUARIO where EMAIL = '{x_email}'";
            resultado_id = bd.consultardados(sql_id);

            DataTable resultado_senha = new DataTable();
            var sql_senha = $"select SENHA from USUARIO where EMAIL = '{x_email}'";
            resultado_senha = bd.consultardados(sql_senha);


            if (txt_senha_alterada.Text != "")
            {
                if (txt_senha_alterada.Text != resultado_senha.Rows[0]["SENHA"].ToString())
                {
                    var sql = $"update USUARIO set SENHA = {txt_senha_alterada.Text} where ID = {resultado_id.Rows[0]["ID"].ToString()};";
                    bd.Alterartabelas(sql);

                    MessageBox.Show("Senha alterada com sucesso");

                    this.Visible = false;
                    frm_telainicial telainicial = new frm_telainicial(string.Empty);
                    telainicial.ShowDialog();
                    this.Visible = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Esta senha já esta vinculada ao seu email");
                }

            }
            else
            {
                MessageBox.Show("Digite alguma senha válida");
            }


            limpar();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frm_telainicial telainicial = new frm_telainicial(string.Empty);
            telainicial.ShowDialog();
            this.Visible = true;
            this.Close();
        }
    }
}
