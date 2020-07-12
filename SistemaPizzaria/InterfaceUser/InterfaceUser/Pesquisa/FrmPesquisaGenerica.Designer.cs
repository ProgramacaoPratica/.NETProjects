namespace InterfaceUser.Pesquisa {
    partial class FrmPesquisaGenerica {
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
            this.flwpanelpesquisa = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_sair_pesquisa = new System.Windows.Forms.Button();
            this.btn_confirmar_pesquisa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbuscapesquisa = new System.Windows.Forms.TextBox();
            this.gpbbuscapesquisa = new System.Windows.Forms.GroupBox();
            this.optsomenteinativos = new System.Windows.Forms.RadioButton();
            this.optsomenteativos = new System.Windows.Forms.RadioButton();
            this.opttodos = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvllistagem = new System.Windows.Forms.ListView();
            this.flwpanelpesquisa.SuspendLayout();
            this.gpbbuscapesquisa.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flwpanelpesquisa
            // 
            this.flwpanelpesquisa.Controls.Add(this.btn_sair_pesquisa);
            this.flwpanelpesquisa.Controls.Add(this.btn_confirmar_pesquisa);
            this.flwpanelpesquisa.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flwpanelpesquisa.Location = new System.Drawing.Point(312, 467);
            this.flwpanelpesquisa.Name = "flwpanelpesquisa";
            this.flwpanelpesquisa.Size = new System.Drawing.Size(229, 50);
            this.flwpanelpesquisa.TabIndex = 0;
            // 
            // btn_sair_pesquisa
            // 
            this.btn_sair_pesquisa.Image = global::InterfaceUser.Properties.Resources.sair;
            this.btn_sair_pesquisa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_sair_pesquisa.Location = new System.Drawing.Point(121, 3);
            this.btn_sair_pesquisa.Name = "btn_sair_pesquisa";
            this.btn_sair_pesquisa.Size = new System.Drawing.Size(105, 45);
            this.btn_sair_pesquisa.TabIndex = 1;
            this.btn_sair_pesquisa.Text = "Sair";
            this.btn_sair_pesquisa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_sair_pesquisa.UseVisualStyleBackColor = true;
            this.btn_sair_pesquisa.Click += new System.EventHandler(this.btn_sair_pesquisa_Click);
            // 
            // btn_confirmar_pesquisa
            // 
            this.btn_confirmar_pesquisa.Image = global::InterfaceUser.Properties.Resources.confirmar;
            this.btn_confirmar_pesquisa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_confirmar_pesquisa.Location = new System.Drawing.Point(10, 3);
            this.btn_confirmar_pesquisa.Name = "btn_confirmar_pesquisa";
            this.btn_confirmar_pesquisa.Size = new System.Drawing.Size(105, 45);
            this.btn_confirmar_pesquisa.TabIndex = 2;
            this.btn_confirmar_pesquisa.Text = "Confirmar";
            this.btn_confirmar_pesquisa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_confirmar_pesquisa.UseVisualStyleBackColor = true;
            this.btn_confirmar_pesquisa.Click += new System.EventHandler(this.btn_confirmar_pesquisa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Busca";
            // 
            // txtbuscapesquisa
            // 
            this.txtbuscapesquisa.Location = new System.Drawing.Point(34, 41);
            this.txtbuscapesquisa.Name = "txtbuscapesquisa";
            this.txtbuscapesquisa.Size = new System.Drawing.Size(507, 20);
            this.txtbuscapesquisa.TabIndex = 2;
            this.txtbuscapesquisa.TextChanged += new System.EventHandler(this.txtbuscapesquisa_TextChanged);
            // 
            // gpbbuscapesquisa
            // 
            this.gpbbuscapesquisa.Controls.Add(this.optsomenteinativos);
            this.gpbbuscapesquisa.Controls.Add(this.optsomenteativos);
            this.gpbbuscapesquisa.Controls.Add(this.opttodos);
            this.gpbbuscapesquisa.Location = new System.Drawing.Point(34, 97);
            this.gpbbuscapesquisa.Name = "gpbbuscapesquisa";
            this.gpbbuscapesquisa.Size = new System.Drawing.Size(507, 54);
            this.gpbbuscapesquisa.TabIndex = 3;
            this.gpbbuscapesquisa.TabStop = false;
            this.gpbbuscapesquisa.Text = "Situação";
            // 
            // optsomenteinativos
            // 
            this.optsomenteinativos.AutoSize = true;
            this.optsomenteinativos.Location = new System.Drawing.Point(324, 19);
            this.optsomenteinativos.Name = "optsomenteinativos";
            this.optsomenteinativos.Size = new System.Drawing.Size(113, 17);
            this.optsomenteinativos.TabIndex = 2;
            this.optsomenteinativos.TabStop = true;
            this.optsomenteinativos.Text = "Somente Invativos";
            this.optsomenteinativos.UseVisualStyleBackColor = true;
            this.optsomenteinativos.CheckedChanged += new System.EventHandler(this.optsomenteinativos_CheckedChanged);
            // 
            // optsomenteativos
            // 
            this.optsomenteativos.AutoSize = true;
            this.optsomenteativos.Location = new System.Drawing.Point(182, 19);
            this.optsomenteativos.Name = "optsomenteativos";
            this.optsomenteativos.Size = new System.Drawing.Size(99, 17);
            this.optsomenteativos.TabIndex = 1;
            this.optsomenteativos.TabStop = true;
            this.optsomenteativos.Text = "Somente Ativos";
            this.optsomenteativos.UseVisualStyleBackColor = true;
            this.optsomenteativos.CheckedChanged += new System.EventHandler(this.optsomenteativos_CheckedChanged);
            // 
            // opttodos
            // 
            this.opttodos.AutoSize = true;
            this.opttodos.Location = new System.Drawing.Point(69, 19);
            this.opttodos.Name = "opttodos";
            this.opttodos.Size = new System.Drawing.Size(55, 17);
            this.opttodos.TabIndex = 0;
            this.opttodos.TabStop = true;
            this.opttodos.Text = "Todos";
            this.opttodos.UseVisualStyleBackColor = true;
            this.opttodos.CheckedChanged += new System.EventHandler(this.opttodos_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvllistagem);
            this.groupBox1.Location = new System.Drawing.Point(34, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 304);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listagem de Dados";
            // 
            // lvllistagem
            // 
            this.lvllistagem.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvllistagem.FullRowSelect = true;
            this.lvllistagem.GridLines = true;
            this.lvllistagem.HideSelection = false;
            this.lvllistagem.Location = new System.Drawing.Point(0, 19);
            this.lvllistagem.Name = "lvllistagem";
            this.lvllistagem.Size = new System.Drawing.Size(504, 285);
            this.lvllistagem.TabIndex = 0;
            this.lvllistagem.UseCompatibleStateImageBehavior = false;
            this.lvllistagem.DoubleClick += new System.EventHandler(this.lvllistagem_DoubleClick);
            // 
            // FrmPesquisaGenerica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 529);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpbbuscapesquisa);
            this.Controls.Add(this.txtbuscapesquisa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flwpanelpesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "FrmPesquisaGenerica";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa";
            this.Load += new System.EventHandler(this.FrmPesquisaGenerica_Load);
            this.flwpanelpesquisa.ResumeLayout(false);
            this.gpbbuscapesquisa.ResumeLayout(false);
            this.gpbbuscapesquisa.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flwpanelpesquisa;
        private System.Windows.Forms.Button btn_sair_pesquisa;
        private System.Windows.Forms.Button btn_confirmar_pesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbuscapesquisa;
        private System.Windows.Forms.GroupBox gpbbuscapesquisa;
        private System.Windows.Forms.RadioButton optsomenteinativos;
        private System.Windows.Forms.RadioButton optsomenteativos;
        private System.Windows.Forms.RadioButton opttodos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvllistagem;
    }
}