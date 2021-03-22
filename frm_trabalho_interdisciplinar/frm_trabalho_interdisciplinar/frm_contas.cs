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
    public partial class frm_contas : Form
    {
        public frm_contas()
        {
            InitializeComponent();
        }
        ConexaoBD bd = new ConexaoBD();
        DateTime data;

        public void limpar()
        {
            txt_nome_conta.Clear();

        }

        public void listar()
        {
            var sql = "select CONTA.ID as ID_CONTA, CONTA.NOME as NOME_CONTA, CONTA.TIPO, CATEGORIA.NOME as NOME_CATEGORIA, CATEGORIA.ID as ID_CATEGORIA FROM CATEGORIA JOIN CONTA ON CONTA.CATEGORIA_ID = CATEGORIA.ID";
            dtg_listar_conta.DataSource = bd.consultardados(sql);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frm_contas_Load(object sender, EventArgs e)
        {
            listar();

            DataTable resultado = new DataTable();
            var sql = $"select ID, NOME from CATEGORIA";
            resultado = bd.consultardados(sql);

            cbx_categoria_conta.DataSource = resultado;
            cbx_categoria_conta.DisplayMember = "NOME";
            cbx_categoria_conta.ValueMember = "ID";



            btn_alterar_conta.Enabled = false;

        }

        private void btn_salvar_conta_Click(object sender, EventArgs e)
        {
           // DataTable resultadoid = new DataTable();
           // var sql = $"select ID from CATEGORIA where NOME = '{((System.Data.DataRowView)cbx_categoria_conta.SelectedItem).Row[0]}'";
           // resultadoid = bd.consultardados(sql);

            if (txt_nome_conta.Text != "" && cbx_tipo_conta.Text != "")
            {
                DataTable resultado_id = new DataTable();
                var sql_id = $"select ID from CATEGORIA where NOME = '{((System.Data.DataRowView)cbx_categoria_conta.SelectedItem).Row[1]}'";
                resultado_id = bd.consultardados(sql_id);

                var sql_insert = $"insert into CONTA (NOME, TIPO, CATEGORIA_ID) values ('{txt_nome_conta.Text}' , '{cbx_tipo_conta.SelectedItem.ToString()}' , {resultado_id.Rows[0]["ID"] })";
                bd.Alterartabelas(sql_insert);
                listar();
                limpar();
            }
            else
            {
                MessageBox.Show("Preencha os campos acima");
            }


        }

        private void btn_alterar_conta_Click(object sender, EventArgs e)
        {
            DataTable resultado = new DataTable();
            var sql = $"select ID from CATEGORIA where ID = '{txt_id_categoria.Text}'";
            resultado = bd.consultardados(sql);

            sql = $"update CONTA set CATEGORIA_ID = {((System.Data.DataRowView)cbx_categoria_conta.SelectedItem).Row[0]} where ID = '{txt_id_conta.Text}';";
            bd.Alterartabelas(sql);

            // --- // --- //

            DataTable id_conta = new DataTable();
            var sql_id = $"select ID from CONTA where ID = '{txt_id_conta.Text}'";
            id_conta = bd.consultardados(sql_id);

            var sql_id_conta = $"update CONTA set TIPO = '{cbx_tipo_conta.SelectedItem}' where ID = {id_conta.Rows[0]["ID"]}";
            bd.Alterartabelas(sql_id_conta);

            // --- // --- //

            DataTable nome_conta = new DataTable();
            var sql_nome = $"select ID from CONTA where ID = '{txt_id_conta.Text}'";
            nome_conta = bd.consultardados(sql_nome);

            var sql_nome_conta = $"update CONTA set NOME = '{txt_nome_conta.Text}' where ID = {nome_conta.Rows[0]["ID"]}";
            bd.Alterartabelas(sql_nome_conta);
            listar();
            limpar();
            btn_salvar_conta.Enabled = true;
            btn_alterar_conta.Enabled = false;
        }

        private void dtg_listar_conta_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            btn_salvar_conta.Enabled = false;
            btn_alterar_conta.Enabled = true;

            txt_id_conta.Text = dtg_listar_conta.CurrentRow.Cells[0].Value.ToString();
            txt_nome_conta.Text = dtg_listar_conta.CurrentRow.Cells[1].Value.ToString();
            cbx_tipo_conta.Text = dtg_listar_conta.CurrentRow.Cells[2].Value.ToString();
            cbx_categoria_conta.Text = dtg_listar_conta.CurrentRow.Cells[3].Value.ToString();
            txt_id_categoria.Text = dtg_listar_conta.CurrentRow.Cells[4].Value.ToString();

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
