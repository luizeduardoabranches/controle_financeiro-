namespace frm_trabalho_interdisciplinar
{
    partial class frm_alterar_senha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_alterar_senha));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_senha_alterada = new System.Windows.Forms.TextBox();
            this.btn_alterar_senha = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(155, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Alterar senha";
            // 
            // txt_senha_alterada
            // 
            this.txt_senha_alterada.Location = new System.Drawing.Point(155, 116);
            this.txt_senha_alterada.Name = "txt_senha_alterada";
            this.txt_senha_alterada.Size = new System.Drawing.Size(180, 20);
            this.txt_senha_alterada.TabIndex = 3;
            // 
            // btn_alterar_senha
            // 
            this.btn_alterar_senha.Location = new System.Drawing.Point(155, 157);
            this.btn_alterar_senha.Name = "btn_alterar_senha";
            this.btn_alterar_senha.Size = new System.Drawing.Size(117, 33);
            this.btn_alterar_senha.TabIndex = 4;
            this.btn_alterar_senha.Text = "alterar";
            this.btn_alterar_senha.UseVisualStyleBackColor = true;
            this.btn_alterar_senha.Click += new System.EventHandler(this.btn_alterar_senha_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(57, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Alteração de senha";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.IndianRed;
            this.panel10.Location = new System.Drawing.Point(62, 49);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(210, 3);
            this.panel10.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frm_alterar_senha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(62)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(455, 289);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_alterar_senha);
            this.Controls.Add(this.txt_senha_alterada);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_alterar_senha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_alterar_senha";
            this.Load += new System.EventHandler(this.frm_alterar_senha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_senha_alterada;
        private System.Windows.Forms.Button btn_alterar_senha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}