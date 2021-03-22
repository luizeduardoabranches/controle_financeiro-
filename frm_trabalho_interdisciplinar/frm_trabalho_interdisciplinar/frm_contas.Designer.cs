namespace frm_trabalho_interdisciplinar
{
    partial class frm_contas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_contas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_id_categoria = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_id_conta = new System.Windows.Forms.TextBox();
            this.btn_alterar_conta = new System.Windows.Forms.Button();
            this.btn_salvar_conta = new System.Windows.Forms.Button();
            this.cbx_categoria_conta = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_tipo_conta = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nome_conta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtg_listar_conta = new System.Windows.Forms.DataGridView();
            this.ID_CONTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgNOME_CONTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgNOME_CATEGORIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgID_CATEGORIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_listar_conta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(62)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_id_categoria);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_id_conta);
            this.panel1.Controls.Add(this.btn_alterar_conta);
            this.panel1.Controls.Add(this.btn_salvar_conta);
            this.panel1.Controls.Add(this.cbx_categoria_conta);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbx_tipo_conta);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_nome_conta);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(511, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 353);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(22, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(299, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "* Para alterar alguma conta basta clicar na tabela ao lado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(147, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "ID_categoria*";
            this.label5.Visible = false;
            // 
            // txt_id_categoria
            // 
            this.txt_id_categoria.Enabled = false;
            this.txt_id_categoria.Location = new System.Drawing.Point(151, 317);
            this.txt_id_categoria.Name = "txt_id_categoria";
            this.txt_id_categoria.Size = new System.Drawing.Size(89, 20);
            this.txt_id_categoria.TabIndex = 10;
            this.txt_id_categoria.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(22, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "ID*";
            this.label4.Visible = false;
            // 
            // txt_id_conta
            // 
            this.txt_id_conta.Enabled = false;
            this.txt_id_conta.Location = new System.Drawing.Point(25, 317);
            this.txt_id_conta.Name = "txt_id_conta";
            this.txt_id_conta.Size = new System.Drawing.Size(63, 20);
            this.txt_id_conta.TabIndex = 8;
            this.txt_id_conta.Visible = false;
            // 
            // btn_alterar_conta
            // 
            this.btn_alterar_conta.Location = new System.Drawing.Point(154, 230);
            this.btn_alterar_conta.Name = "btn_alterar_conta";
            this.btn_alterar_conta.Size = new System.Drawing.Size(117, 33);
            this.btn_alterar_conta.TabIndex = 9;
            this.btn_alterar_conta.Text = "Alterar";
            this.btn_alterar_conta.UseVisualStyleBackColor = true;
            this.btn_alterar_conta.Click += new System.EventHandler(this.btn_alterar_conta_Click);
            // 
            // btn_salvar_conta
            // 
            this.btn_salvar_conta.Location = new System.Drawing.Point(25, 230);
            this.btn_salvar_conta.Name = "btn_salvar_conta";
            this.btn_salvar_conta.Size = new System.Drawing.Size(117, 33);
            this.btn_salvar_conta.TabIndex = 8;
            this.btn_salvar_conta.Text = "Salvar";
            this.btn_salvar_conta.UseVisualStyleBackColor = true;
            this.btn_salvar_conta.Click += new System.EventHandler(this.btn_salvar_conta_Click);
            // 
            // cbx_categoria_conta
            // 
            this.cbx_categoria_conta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_categoria_conta.FormattingEnabled = true;
            this.cbx_categoria_conta.Location = new System.Drawing.Point(25, 175);
            this.cbx_categoria_conta.Name = "cbx_categoria_conta";
            this.cbx_categoria_conta.Size = new System.Drawing.Size(342, 21);
            this.cbx_categoria_conta.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(25, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Categoria";
            // 
            // cbx_tipo_conta
            // 
            this.cbx_tipo_conta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_tipo_conta.FormattingEnabled = true;
            this.cbx_tipo_conta.Items.AddRange(new object[] {
            "Despesa",
            "Receita"});
            this.cbx_tipo_conta.Location = new System.Drawing.Point(25, 120);
            this.cbx_tipo_conta.Name = "cbx_tipo_conta";
            this.cbx_tipo_conta.Size = new System.Drawing.Size(341, 21);
            this.cbx_tipo_conta.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(25, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tipo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_nome_conta
            // 
            this.txt_nome_conta.Location = new System.Drawing.Point(25, 65);
            this.txt_nome_conta.Name = "txt_nome_conta";
            this.txt_nome_conta.Size = new System.Drawing.Size(342, 20);
            this.txt_nome_conta.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(25, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // dtg_listar_conta
            // 
            this.dtg_listar_conta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(62)))), ((int)(((byte)(102)))));
            this.dtg_listar_conta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_listar_conta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_CONTA,
            this.dgNOME_CONTA,
            this.dgTIPO,
            this.dgNOME_CATEGORIA,
            this.dgID_CATEGORIA});
            this.dtg_listar_conta.Location = new System.Drawing.Point(33, 90);
            this.dtg_listar_conta.Name = "dtg_listar_conta";
            this.dtg_listar_conta.Size = new System.Drawing.Size(460, 353);
            this.dtg_listar_conta.TabIndex = 1;
            this.dtg_listar_conta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_listar_conta_CellClick);
            // 
            // ID_CONTA
            // 
            this.ID_CONTA.DataPropertyName = "ID_CONTA";
            this.ID_CONTA.HeaderText = "Conta";
            this.ID_CONTA.Name = "ID_CONTA";
            this.ID_CONTA.Visible = false;
            // 
            // dgNOME_CONTA
            // 
            this.dgNOME_CONTA.DataPropertyName = "NOME_CONTA";
            this.dgNOME_CONTA.HeaderText = "Nome";
            this.dgNOME_CONTA.Name = "dgNOME_CONTA";
            this.dgNOME_CONTA.Width = 217;
            // 
            // dgTIPO
            // 
            this.dgTIPO.DataPropertyName = "TIPO";
            this.dgTIPO.HeaderText = "Tipo";
            this.dgTIPO.Name = "dgTIPO";
            // 
            // dgNOME_CATEGORIA
            // 
            this.dgNOME_CATEGORIA.DataPropertyName = "NOME_CATEGORIA";
            this.dgNOME_CATEGORIA.HeaderText = "Categoria";
            this.dgNOME_CATEGORIA.Name = "dgNOME_CATEGORIA";
            // 
            // dgID_CATEGORIA
            // 
            this.dgID_CATEGORIA.DataPropertyName = "ID_CATEGORIA";
            this.dgID_CATEGORIA.HeaderText = "id_categoria";
            this.dgID_CATEGORIA.Name = "dgID_CATEGORIA";
            this.dgID_CATEGORIA.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(71, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Cadastro de contas";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.IndianRed;
            this.panel10.Location = new System.Drawing.Point(76, 71);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(210, 3);
            this.panel10.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frm_contas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(929, 544);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtg_listar_conta);
            this.Controls.Add(this.panel1);
            this.Name = "frm_contas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de contas";
            this.Load += new System.EventHandler(this.frm_contas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_listar_conta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtg_listar_conta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nome_conta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_categoria_conta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_tipo_conta;
        private System.Windows.Forms.Button btn_alterar_conta;
        private System.Windows.Forms.Button btn_salvar_conta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_id_conta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_id_categoria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CONTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgNOME_CONTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgNOME_CATEGORIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgID_CATEGORIA;
    }
}