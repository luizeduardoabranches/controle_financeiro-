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
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }
        Login obj_login = new Login();


        

        private void btn_cadusuario_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frm_cadusuario cadusuario = new frm_cadusuario();
            cadusuario.ShowDialog();
            this.Visible = true;
            this.Close();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            if (txt_email.Text != "" || txt_senha.Text != "") 
            {
                if (obj_login.validarusuario(txt_email.Text, txt_senha.Text))
                {
                    this.Visible = false;
                    frm_telainicial telainicial = new frm_telainicial(txt_email.Text);
                    telainicial.ShowDialog();
                    this.Visible = true;

                    
    }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos...");
                }
            }
            else
            {
                MessageBox.Show("Preencha os campos pedidos...");
            }
            
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_login_Load(object sender, EventArgs e)
        {

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
