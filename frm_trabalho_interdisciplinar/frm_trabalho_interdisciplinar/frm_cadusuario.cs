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
    public partial class frm_cadusuario : Form
    {
        public frm_cadusuario()
        {
            InitializeComponent();
        }

        ConexaoBD bd = new ConexaoBD();
        string sql; 
        private void btn_novo_Click(object sender, EventArgs e)
        {
            
            if (txt_csenha.Text != "" && txt_email.Text != "" && txt_nome.Text != "" && txt_senha.Text != "")
            {
                DataTable resultado = new DataTable();
                var sql = $"select EMAIL from USUARIO";
                resultado = bd.consultardados(sql);

                if (txt_csenha.Text == txt_senha.Text)
                {
                    if (resultado.Rows.Count <= 0)
                    {
                        sql = $"insert into USUARIO (NOME,EMAIL,SENHA) values ('{txt_nome.Text}','{txt_email.Text}','{txt_senha.Text}')";
                        bd.Alterartabelas(sql);
                        MessageBox.Show("Usuário cadastrado com sucesso ...");

                        this.Visible = false;
                        frm_login telalogin = new frm_login();
                        telalogin.ShowDialog();
                        this.Visible = true;
                        this.Close();
                    }
                    else if(txt_email.Text != resultado.Rows[0]["EMAIL"].ToString())
                    {
                        sql = $"insert into USUARIO (NOME,EMAIL,SENHA) values ('{txt_nome.Text}','{txt_email.Text}','{txt_senha.Text}')";
                        bd.Alterartabelas(sql);
                        MessageBox.Show("Usuário cadastrado com sucesso ...");

                        this.Visible = false;
                        frm_login telalogin = new frm_login();
                        telalogin.ShowDialog();
                        this.Visible = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Usuário já cadastrado");
                        txt_senha.Clear();
                        txt_csenha.Clear();
                        txt_senha.Focus();
                    }
                        
                }               
                
                else
                {
                    MessageBox.Show("Senhas não conferem ...");
                    txt_senha.Clear();
                    txt_csenha.Clear();
                    txt_senha.Focus();
                }
            }
            else
            {
                MessageBox.Show("Preencha os campos acima corretamente");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frm_login telalogin = new frm_login();
            telalogin.ShowDialog();
            this.Visible = true;
            this.Close();          
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {

        }

        private void frm_cadusuario_Load(object sender, EventArgs e)
        {

        }
    }
}
