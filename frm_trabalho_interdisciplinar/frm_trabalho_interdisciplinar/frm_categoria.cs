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
    public partial class frm_categoria : Form
    {
        public frm_categoria()
        {
            InitializeComponent();
        }
        ConexaoBD bd = new ConexaoBD();
        string sql;
        DateTime data;

        public void limpar()
        {
            txt_nome_categoria.Clear();
        }

        public void listar()
        {
            sql = "select * from CATEGORIA;";
            dtg_listar_categoria.DataSource = bd.consultardados(sql);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_salvar_categorias_Click(object sender, EventArgs e)
        {
            if(txt_nome_categoria.Text != "")
            {
                sql = $"insert into CATEGORIA (NOME) values ('{txt_nome_categoria.Text}')";
                bd.Alterartabelas(sql);
                listar();
                limpar();
            }
            else
            {
                MessageBox.Show("Preencha os campos acima");
            }
            
        }

        private void dtg_listar_categoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_nome_categoria.Text = dtg_listar_categoria.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
        private void frm_categoria_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_alterar_categorias_Click(object sender, EventArgs e)
        {
                var sql = $"update CATEGORIA set NOME = '{txt_nome_categoria.Text}' where ID = '{txt_id_categoria.Text}'";
                bd.Alterartabelas(sql);
                listar();
                limpar();
                btn_alterar_categorias.Enabled = false;
                btn_salvar_categorias.Enabled = true;
        }

        private void dtg_listar_categoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_salvar_categorias.Enabled = false;
            btn_alterar_categorias.Enabled = true;

            txt_id_categoria.Text = dtg_listar_categoria.CurrentRow.Cells[0].Value.ToString();
            txt_nome_categoria.Text = dtg_listar_categoria.CurrentRow.Cells[1].Value.ToString();


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_categoria_Load_1(object sender, EventArgs e)
        {
            listar();
            btn_alterar_categorias.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frm_telainicial telainicial = new frm_telainicial(string.Empty);
            telainicial.ShowDialog();
            this.Visible = true;
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
