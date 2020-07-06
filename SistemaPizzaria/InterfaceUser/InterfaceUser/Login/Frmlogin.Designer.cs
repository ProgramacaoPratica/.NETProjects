namespace InterfaceUser.Login {
    partial class Frmlogin {
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
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblusuario = new System.Windows.Forms.Label();
            this.lblsenha = new System.Windows.Forms.Label();
            this.cmbusuarios = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblpizzaria = new System.Windows.Forms.Label();
            this.lblcopyright = new System.Windows.Forms.Label();
            this.lblversao = new System.Windows.Forms.Label();
            this.btn_sair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.BackgroundImage = global::InterfaceUser.Properties.Resources.logo_login;
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLogo.Location = new System.Drawing.Point(650, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(329, 265);
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.BackColor = System.Drawing.Color.Transparent;
            this.lblusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.Location = new System.Drawing.Point(681, 300);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(50, 16);
            this.lblusuario.TabIndex = 1;
            this.lblusuario.Text = "Login:";
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.BackColor = System.Drawing.Color.Transparent;
            this.lblsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsenha.Location = new System.Drawing.Point(681, 361);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(56, 16);
            this.lblsenha.TabIndex = 2;
            this.lblsenha.Text = "Senha:";
            // 
            // cmbusuarios
            // 
            this.cmbusuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbusuarios.FormattingEnabled = true;
            this.cmbusuarios.Location = new System.Drawing.Point(737, 300);
            this.cmbusuarios.Name = "cmbusuarios";
            this.cmbusuarios.Size = new System.Drawing.Size(191, 21);
            this.cmbusuarios.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(743, 361);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 20);
            this.textBox1.TabIndex = 4;
            // 
            // btn_entrar
            // 
            this.btn_entrar.Location = new System.Drawing.Point(737, 411);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(75, 35);
            this.btn_entrar.TabIndex = 5;
            this.btn_entrar.Text = "Entrar";
            this.btn_entrar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblversao);
            this.panel1.Controls.Add(this.lblcopyright);
            this.panel1.Controls.Add(this.lblpizzaria);
            this.panel1.Location = new System.Drawing.Point(684, 479);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 137);
            this.panel1.TabIndex = 7;
            // 
            // lblpizzaria
            // 
            this.lblpizzaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpizzaria.Location = new System.Drawing.Point(70, 14);
            this.lblpizzaria.Name = "lblpizzaria";
            this.lblpizzaria.Size = new System.Drawing.Size(191, 34);
            this.lblpizzaria.TabIndex = 0;
            this.lblpizzaria.Text = "Sistema Pizzaria";
            this.lblpizzaria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblcopyright
            // 
            this.lblcopyright.AutoSize = true;
            this.lblcopyright.Location = new System.Drawing.Point(50, 103);
            this.lblcopyright.Name = "lblcopyright";
            this.lblcopyright.Size = new System.Drawing.Size(234, 13);
            this.lblcopyright.TabIndex = 1;
            this.lblcopyright.Text = "copyright © Winilson de Paula (WS SISTEMAS)";
            // 
            // lblversao
            // 
            this.lblversao.AutoSize = true;
            this.lblversao.Location = new System.Drawing.Point(106, 66);
            this.lblversao.Name = "lblversao";
            this.lblversao.Size = new System.Drawing.Size(111, 13);
            this.lblversao.TabIndex = 2;
            this.lblversao.Text = "Versão: {0}.{1}.{2}.{3}";
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(853, 411);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 35);
            this.btn_sair.TabIndex = 8;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            // 
            // Frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InterfaceUser.Properties.Resources.fundo_login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1059, 657);
            this.ControlBox = false;
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_entrar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmbusuarios);
            this.Controls.Add(this.lblsenha);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.picLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Frmlogin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acesso ao Sistema";
            this.Load += new System.EventHandler(this.Frmlogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label lblsenha;
        private System.Windows.Forms.ComboBox cmbusuarios;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_entrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblversao;
        private System.Windows.Forms.Label lblcopyright;
        private System.Windows.Forms.Label lblpizzaria;
        private System.Windows.Forms.Button btn_sair;
    }
}