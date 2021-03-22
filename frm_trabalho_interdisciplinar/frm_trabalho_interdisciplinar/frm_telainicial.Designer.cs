namespace frm_trabalho_interdisciplinar
{
    partial class frm_telainicial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.dtg_lancamento = new System.Windows.Forms.DataGridView();
            this.dgNOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgVALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDATA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp_data_lancamento = new System.Windows.Forms.DateTimePicker();
            this.txt_valor_lancamento = new System.Windows.Forms.TextBox();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.cbx_conta_lancamento = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lbl_despesas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_resultado_final = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_receita = new System.Windows.Forms.Label();
            this.btn_contas = new System.Windows.Forms.Button();
            this.btn_categoria = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_alterar_senha = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_lancamento)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.panel2.Controls.Add(this.panel13);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Location = new System.Drawing.Point(169, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(803, 506);
            this.panel2.TabIndex = 1;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(62)))), ((int)(((byte)(102)))));
            this.panel13.Controls.Add(this.dtg_lancamento);
            this.panel13.Location = new System.Drawing.Point(88, 352);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(572, 120);
            this.panel13.TabIndex = 4;
            // 
            // dtg_lancamento
            // 
            this.dtg_lancamento.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(62)))), ((int)(((byte)(102)))));
            this.dtg_lancamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_lancamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgNOME,
            this.dgVALOR,
            this.dgDATA});
            this.dtg_lancamento.Location = new System.Drawing.Point(13, 13);
            this.dtg_lancamento.Name = "dtg_lancamento";
            this.dtg_lancamento.Size = new System.Drawing.Size(544, 90);
            this.dtg_lancamento.TabIndex = 0;
            // 
            // dgNOME
            // 
            this.dgNOME.DataPropertyName = "NOME";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgNOME.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgNOME.HeaderText = "Nome";
            this.dgNOME.Name = "dgNOME";
            this.dgNOME.Width = 280;
            // 
            // dgVALOR
            // 
            this.dgVALOR.DataPropertyName = "VALOR";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.dgVALOR.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgVALOR.HeaderText = "Valor";
            this.dgVALOR.Name = "dgVALOR";
            // 
            // dgDATA
            // 
            this.dgDATA.DataPropertyName = "DATA";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.dgDATA.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgDATA.HeaderText = "Data";
            this.dgDATA.Name = "dgDATA";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel12);
            this.panel5.Controls.Add(this.panel11);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.panel10);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(68, 8);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(622, 338);
            this.panel5.TabIndex = 0;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(62)))), ((int)(((byte)(102)))));
            this.panel12.Controls.Add(this.label7);
            this.panel12.Location = new System.Drawing.Point(3, 358);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(214, 106);
            this.panel12.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(8, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "DESPESAS";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(62)))), ((int)(((byte)(102)))));
            this.panel11.Controls.Add(this.label8);
            this.panel11.Controls.Add(this.dtp_data_lancamento);
            this.panel11.Controls.Add(this.txt_valor_lancamento);
            this.panel11.Controls.Add(this.btn_salvar);
            this.panel11.Controls.Add(this.cbx_conta_lancamento);
            this.panel11.Controls.Add(this.label4);
            this.panel11.Controls.Add(this.label3);
            this.panel11.Location = new System.Drawing.Point(315, 66);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(277, 246);
            this.panel11.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(24, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Data";
            // 
            // dtp_data_lancamento
            // 
            this.dtp_data_lancamento.Location = new System.Drawing.Point(24, 159);
            this.dtp_data_lancamento.Name = "dtp_data_lancamento";
            this.dtp_data_lancamento.Size = new System.Drawing.Size(225, 20);
            this.dtp_data_lancamento.TabIndex = 6;
            // 
            // txt_valor_lancamento
            // 
            this.txt_valor_lancamento.Location = new System.Drawing.Point(24, 102);
            this.txt_valor_lancamento.Name = "txt_valor_lancamento";
            this.txt_valor_lancamento.Size = new System.Drawing.Size(225, 20);
            this.txt_valor_lancamento.TabIndex = 5;
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(24, 196);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(117, 33);
            this.btn_salvar.TabIndex = 4;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // cbx_conta_lancamento
            // 
            this.cbx_conta_lancamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_conta_lancamento.FormattingEnabled = true;
            this.cbx_conta_lancamento.Location = new System.Drawing.Point(24, 49);
            this.cbx_conta_lancamento.Name = "cbx_conta_lancamento";
            this.cbx_conta_lancamento.Size = new System.Drawing.Size(225, 21);
            this.cbx_conta_lancamento.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(24, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(24, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Conta";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(62)))), ((int)(((byte)(102)))));
            this.panel8.Controls.Add(this.lbl_despesas);
            this.panel8.Controls.Add(this.label1);
            this.panel8.Location = new System.Drawing.Point(154, 66);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(128, 120);
            this.panel8.TabIndex = 4;
            // 
            // lbl_despesas
            // 
            this.lbl_despesas.AutoSize = true;
            this.lbl_despesas.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_despesas.ForeColor = System.Drawing.Color.White;
            this.lbl_despesas.Location = new System.Drawing.Point(29, 47);
            this.lbl_despesas.Name = "lbl_despesas";
            this.lbl_despesas.Size = new System.Drawing.Size(17, 20);
            this.lbl_despesas.TabIndex = 1;
            this.lbl_despesas.Text = "0";
            this.lbl_despesas.Click += new System.EventHandler(this.lbl_despesas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Despesas";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(62)))), ((int)(((byte)(102)))));
            this.panel7.Location = new System.Drawing.Point(154, 192);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(128, 120);
            this.panel7.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(62)))), ((int)(((byte)(102)))));
            this.panel4.Controls.Add(this.lbl_resultado_final);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(20, 192);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(128, 120);
            this.panel4.TabIndex = 2;
            // 
            // lbl_resultado_final
            // 
            this.lbl_resultado_final.AutoSize = true;
            this.lbl_resultado_final.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultado_final.ForeColor = System.Drawing.Color.White;
            this.lbl_resultado_final.Location = new System.Drawing.Point(22, 51);
            this.lbl_resultado_final.Name = "lbl_resultado_final";
            this.lbl_resultado_final.Size = new System.Drawing.Size(17, 20);
            this.lbl_resultado_final.TabIndex = 2;
            this.lbl_resultado_final.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(22, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Valor Total";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lançamentos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.IndianRed;
            this.panel10.Location = new System.Drawing.Point(20, 35);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(127, 3);
            this.panel10.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(62)))), ((int)(((byte)(102)))));
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.lbl_receita);
            this.panel6.Location = new System.Drawing.Point(20, 66);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(128, 120);
            this.panel6.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(22, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Receitas";
            // 
            // lbl_receita
            // 
            this.lbl_receita.AutoSize = true;
            this.lbl_receita.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_receita.ForeColor = System.Drawing.Color.White;
            this.lbl_receita.Location = new System.Drawing.Point(22, 47);
            this.lbl_receita.Name = "lbl_receita";
            this.lbl_receita.Size = new System.Drawing.Size(17, 20);
            this.lbl_receita.TabIndex = 2;
            this.lbl_receita.Text = "0";
            // 
            // btn_contas
            // 
            this.btn_contas.Location = new System.Drawing.Point(20, 158);
            this.btn_contas.Name = "btn_contas";
            this.btn_contas.Size = new System.Drawing.Size(117, 33);
            this.btn_contas.TabIndex = 6;
            this.btn_contas.Text = "Cadastrar contas";
            this.btn_contas.UseVisualStyleBackColor = true;
            this.btn_contas.Click += new System.EventHandler(this.btn_contas_Click);
            // 
            // btn_categoria
            // 
            this.btn_categoria.Location = new System.Drawing.Point(20, 116);
            this.btn_categoria.Name = "btn_categoria";
            this.btn_categoria.Size = new System.Drawing.Size(117, 33);
            this.btn_categoria.TabIndex = 5;
            this.btn_categoria.Text = "Cadastrar categorias";
            this.btn_categoria.UseVisualStyleBackColor = true;
            this.btn_categoria.Click += new System.EventHandler(this.btn_categoria_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(15, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 25);
            this.label9.TabIndex = 7;
            this.label9.Text = "Menu";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Location = new System.Drawing.Point(20, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(117, 3);
            this.panel1.TabIndex = 4;
            // 
            // btn_alterar_senha
            // 
            this.btn_alterar_senha.Location = new System.Drawing.Point(20, 197);
            this.btn_alterar_senha.Name = "btn_alterar_senha";
            this.btn_alterar_senha.Size = new System.Drawing.Size(117, 33);
            this.btn_alterar_senha.TabIndex = 8;
            this.btn_alterar_senha.Text = "Alterar senha";
            this.btn_alterar_senha.UseVisualStyleBackColor = true;
            this.btn_alterar_senha.Click += new System.EventHandler(this.btn_alterar_senha_Click);
            // 
            // frm_telainicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(62)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(929, 544);
            this.Controls.Add(this.btn_alterar_senha);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_contas);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_categoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "frm_telainicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de lançamentos";
            this.Load += new System.EventHandler(this.frm_telainicial_Load);
            this.panel2.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_lancamento)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_despesas;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.ComboBox cbx_conta_lancamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_valor_lancamento;
        private System.Windows.Forms.DataGridView dtg_lancamento;
        private System.Windows.Forms.DateTimePicker dtp_data_lancamento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_receita;
        private System.Windows.Forms.Label lbl_resultado_final;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_contas;
        private System.Windows.Forms.Button btn_categoria;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgNOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgVALOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDATA;
        private System.Windows.Forms.Button btn_alterar_senha;
    }
}