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
    public partial class frm_telainicial : Form
    {
        string _email;

        public frm_telainicial(string email)
        {
            InitializeComponent();

            if(email != "")
                _email = email;
        }

        ConexaoBD bd = new ConexaoBD();
        DateTime data;

        public void limpar()
        {
            txt_valor_lancamento.Clear();
        }
        public void listar()
        {
            var sql = "select CONTA.NOME, LANCAMENTO.VALOR, LANCAMENTO.DATA FROM LANCAMENTO JOIN CONTA ON LANCAMENTO.CONTA_ID = CONTA.ID order by VALOR desc;";
            dtg_lancamento.DataSource = bd.consultardados(sql);
        }

        private void frm_telainicial_Load(object sender, EventArgs e)
        {
            listar();

            DataTable resultado = new DataTable();
            var sql = $"select * from CONTA";
            resultado = bd.consultardados(sql);

            for (int i = 0; i < resultado.Rows.Count; i++)
            {
                cbx_conta_lancamento.Items.Add(resultado.Rows[i]["NOME"].ToString());
            }

            if (resultado.Rows.Count > 0)
            {
                DataTable valor_receita = new DataTable();
                var valor_lancamento_receita = $"SELECT SUM(VALOR) SOMAVALOR FROM LANCAMENTO JOIN CONTA ON LANCAMENTO.CONTA_ID = CONTA.ID where CONTA.TIPO = 'Receita';";
                valor_receita = bd.consultardados(valor_lancamento_receita);

                if (valor_receita.Rows[0]["SOMAVALOR"].ToString() != "")
                {
                    var formatado_receita = Convert.ToDecimal(valor_receita.Rows[0]["SOMAVALOR"]);
                    lbl_receita.Text = formatado_receita.ToString("###,###,##0.00");
                }
                else
                {
                    lbl_receita.Text = "0,00";
                }


                // -------- // ---------- //

                DataTable valor_despesa = new DataTable();
                var valor_lancamento_despesa = $"SELECT SUM(VALOR) SOMAVALOR FROM LANCAMENTO JOIN CONTA ON LANCAMENTO.CONTA_ID = CONTA.ID where CONTA.TIPO = 'Despesa';";
                valor_despesa = bd.consultardados(valor_lancamento_despesa);

                if (valor_despesa.Rows[0]["SOMAVALOR"].ToString() != "")
                {
                    var formatado_despesa = Convert.ToDecimal(valor_despesa.Rows[0]["SOMAVALOR"]);
                    lbl_despesas.Text = formatado_despesa.ToString("###,###,##0.00");
                }
                else
                {
                    lbl_despesas.Text = "0,00";
                }
                   

                // -------- // ---------- //

                DataTable valor_final = new DataTable();
                var valor_resultado_final = $"SELECT((select ifnull(SUM(VALOR),0) from LANCAMENTO JOIN CONTA ON LANCAMENTO.CONTA_ID = CONTA.ID WHERE CONTA.TIPO = 'Receita') - (select ifnull(SUM(VALOR),0) from LANCAMENTO JOIN CONTA ON LANCAMENTO.CONTA_ID = CONTA.ID WHERE CONTA.TIPO = 'Despesa'))as 'TOTALPAGAR';";
                valor_final = bd.consultardados(valor_resultado_final);
                if (valor_final.Rows[0]["TOTALPAGAR"].ToString() != "")
                {
                    var formatado_final = Convert.ToDecimal(valor_final.Rows[0]["TOTALPAGAR"]);
                    lbl_resultado_final.Text = formatado_final.ToString("###,###,##0.00");
                }
                else
                {
                    lbl_resultado_final.Text = "0,00";
                }

                

            }
            else
            {
                int valor = 0;
                var formatado_0 = Convert.ToDecimal(valor);

                lbl_despesas.Text = formatado_0.ToString("###,###,##0.00");
                lbl_receita.Text = formatado_0.ToString("###,###,##0.00"); ;
                lbl_resultado_final.Text = formatado_0.ToString("###,###,##0.00"); ;
            }

            DataTable resultado_categoria = new DataTable();
            var sql_categoria = $"select * from CATEGORIA";
            resultado_categoria = bd.consultardados(sql_categoria);

            if (resultado_categoria.Rows.Count > 0)
            {
                btn_contas.Enabled = true;
            }
            else
            {
                btn_contas.Enabled = false;
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if(cbx_conta_lancamento.Text != "" && txt_valor_lancamento.Text != "") 
            {
                DataTable resultadoid = new DataTable();
                var sql = $"select ID from CONTA where NOME = '{cbx_conta_lancamento.SelectedItem}'";
                resultadoid = bd.consultardados(sql);

                sql = $"insert into LANCAMENTO (VALOR, DATA, CONTA_ID) values ('{txt_valor_lancamento.Text}' , '{dtp_data_lancamento.Value.ToString("yyyy-MM-dd")}' , {resultadoid.Rows[0]["ID"] })";
                bd.Alterartabelas(sql);
                listar();

                DataTable valor_receita = new DataTable();
                var valor_lancamento_receita = $"SELECT SUM(VALOR) SOMAVALOR FROM LANCAMENTO JOIN CONTA ON LANCAMENTO.CONTA_ID = CONTA.ID where CONTA.TIPO = 'Receita';";
                valor_receita = bd.consultardados(valor_lancamento_receita);

                if (valor_receita.Rows[0]["SOMAVALOR"].ToString() != "")
                {
                    var formatado_receita = Convert.ToDecimal(valor_receita.Rows[0]["SOMAVALOR"]);
                    lbl_receita.Text = formatado_receita.ToString("###,###,##0.00");
                }
                else
                {
                    lbl_receita.Text = "0,00";
                }


                // -------- // ---------- //

                DataTable valor_despesa = new DataTable();
                var valor_lancamento_despesa = $"SELECT SUM(VALOR) SOMAVALOR FROM LANCAMENTO JOIN CONTA ON LANCAMENTO.CONTA_ID = CONTA.ID where CONTA.TIPO = 'Despesa';";
                valor_despesa = bd.consultardados(valor_lancamento_despesa);

                if (valor_despesa.Rows[0]["SOMAVALOR"].ToString() != "")
                {
                    var formatado_despesa = Convert.ToDecimal(valor_despesa.Rows[0]["SOMAVALOR"]);
                    lbl_despesas.Text = formatado_despesa.ToString("###,###,##0.00");
                }
                else
                {
                    lbl_despesas.Text = "0,00";
                }

                // -------- // ---------- //

                DataTable valor_final = new DataTable();
                var valor_resultado_final = $"SELECT((select ifnull(SUM(VALOR),0) from LANCAMENTO JOIN CONTA ON LANCAMENTO.CONTA_ID = CONTA.ID WHERE CONTA.TIPO = 'Receita') - (select ifnull(SUM(VALOR),0) from LANCAMENTO JOIN CONTA ON LANCAMENTO.CONTA_ID = CONTA.ID WHERE CONTA.TIPO = 'Despesa'))as 'TOTALPAGAR';";
                valor_final = bd.consultardados(valor_resultado_final);
                if (valor_final.Rows[0]["TOTALPAGAR"].ToString() != "")
                {
                    var formatado_final = Convert.ToDecimal(valor_final.Rows[0]["TOTALPAGAR"]);
                    lbl_resultado_final.Text = formatado_final.ToString("###,###,##0.00");
                }
                else
                {
                    lbl_resultado_final.Text = "0,00";
                }

                limpar();
            }
            else
            {
                MessageBox.Show("Preencha os campos acima");
            }
            
        }

        private void lbl_despesas_Click(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_categoria_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frm_categoria telacategoria = new frm_categoria();
            telacategoria.ShowDialog();
            this.Visible = true;
            this.Close();
        }

        private void btn_contas_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frm_contas telacontas = new frm_contas();
            telacontas.ShowDialog();
            this.Visible = true;
            this.Close();
        }

        private void btn_alterar_senha_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frm_alterar_senha telasenha = new frm_alterar_senha(_email);
            telasenha.ShowDialog();
            this.Visible = true;
            this.Close();
        }
    }
}
