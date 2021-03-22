namespace frm_trabalho_interdisciplinar
{
    partial class frm_categoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_categoria));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtg_listar_categoria = new System.Windows.Forms.DataGridView();
            this.dgID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgNOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id_categoria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_alterar_categorias = new System.Windows.Forms.Button();
            this.btn_salvar_categorias = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nome_categoria = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_listar_categoria)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.dtg_listar_categoria);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-3, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(937, 547);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(98, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cadastro de categorias";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.IndianRed;
            this.panel10.Location = new System.Drawing.Point(103, 64);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(210, 3);
            this.panel10.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(59, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dtg_listar_categoria
            // 
            this.dtg_listar_categoria.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(62)))), ((int)(((byte)(102)))));
            this.dtg_listar_categoria.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dtg_listar_categoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_listar_categoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgID,
            this.dgNOME});
            this.dtg_listar_categoria.Location = new System.Drawing.Point(59, 87);
            this.dtg_listar_categoria.Name = "dtg_listar_categoria";
            this.dtg_listar_categoria.Size = new System.Drawing.Size(460, 353);
            this.dtg_listar_categoria.TabIndex = 1;
            this.dtg_listar_categoria.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_listar_categoria_CellClick);
            // 
            // dgID
            // 
            this.dgID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dgID.DataPropertyName = "ID";
            this.dgID.HeaderText = "id";
            this.dgID.Name = "dgID";
            this.dgID.Visible = false;
            // 
            // dgNOME
            // 
            this.dgNOME.DataPropertyName = "NOME";
            this.dgNOME.HeaderText = "Nome";
            this.dgNOME.Name = "dgNOME";
            this.dgNOME.Width = 415;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(62)))), ((int)(((byte)(102)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_id_categoria);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btn_alterar_categorias);
            this.panel2.Controls.Add(this.btn_salvar_categorias);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_nome_categoria);
            this.panel2.Location = new System.Drawing.Point(540, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 353);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(29, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "*para alterar alguma categoria basta clicar na tabela ao lado";
            // 
            // txt_id_categoria
            // 
            this.txt_id_categoria.Location = new System.Drawing.Point(33, 260);
            this.txt_id_categoria.Name = "txt_id_categoria";
            this.txt_id_categoria.ReadOnly = true;
            this.txt_id_categoria.Size = new System.Drawing.Size(53, 20);
            this.txt_id_categoria.TabIndex = 6;
            this.txt_id_categoria.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(30, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID*";
            this.label3.Visible = false;
            // 
            // btn_alterar_categorias
            // 
            this.btn_alterar_categorias.Location = new System.Drawing.Point(152, 126);
            this.btn_alterar_categorias.Name = "btn_alterar_categorias";
            this.btn_alterar_categorias.Size = new System.Drawing.Size(117, 33);
            this.btn_alterar_categorias.TabIndex = 5;
            this.btn_alterar_categorias.Text = "alterar";
            this.btn_alterar_categorias.UseVisualStyleBackColor = true;
            this.btn_alterar_categorias.Click += new System.EventHandler(this.btn_alterar_categorias_Click);
            // 
            // btn_salvar_categorias
            // 
            this.btn_salvar_categorias.Location = new System.Drawing.Point(29, 126);
            this.btn_salvar_categorias.Name = "btn_salvar_categorias";
            this.btn_salvar_categorias.Size = new System.Drawing.Size(117, 33);
            this.btn_salvar_categorias.TabIndex = 4;
            this.btn_salvar_categorias.Text = "salvar";
            this.btn_salvar_categorias.UseVisualStyleBackColor = true;
            this.btn_salvar_categorias.Click += new System.EventHandler(this.btn_salvar_categorias_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(29, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // txt_nome_categoria
            // 
            this.txt_nome_categoria.Location = new System.Drawing.Point(29, 71);
            this.txt_nome_categoria.Name = "txt_nome_categoria";
            this.txt_nome_categoria.Size = new System.Drawing.Size(316, 20);
            this.txt_nome_categoria.TabIndex = 3;
            // 
            // frm_categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 544);
            this.Controls.Add(this.panel1);
            this.Name = "frm_categoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de categorias";
            this.Load += new System.EventHandler(this.frm_categoria_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_listar_categoria)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtg_listar_categoria;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_alterar_categorias;
        private System.Windows.Forms.Button btn_salvar_categorias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nome_categoria;
        private System.Windows.Forms.TextBox txt_id_categoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgNOME;
    }
}