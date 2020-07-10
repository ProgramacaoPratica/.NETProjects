namespace InterfaceUser.UserControls {
    partial class Cstatus {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpbsituacao = new System.Windows.Forms.GroupBox();
            this.optInativo = new System.Windows.Forms.RadioButton();
            this.optAtivo = new System.Windows.Forms.RadioButton();
            this.gpbsituacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbsituacao
            // 
            this.gpbsituacao.Controls.Add(this.optInativo);
            this.gpbsituacao.Controls.Add(this.optAtivo);
            this.gpbsituacao.Location = new System.Drawing.Point(0, 0);
            this.gpbsituacao.Name = "gpbsituacao";
            this.gpbsituacao.Size = new System.Drawing.Size(199, 69);
            this.gpbsituacao.TabIndex = 0;
            this.gpbsituacao.TabStop = false;
            this.gpbsituacao.Text = "Status";
            this.gpbsituacao.Enter += new System.EventHandler(this.gpbsituacao_Enter);
            // 
            // optInativo
            // 
            this.optInativo.AutoSize = true;
            this.optInativo.Location = new System.Drawing.Point(110, 18);
            this.optInativo.Name = "optInativo";
            this.optInativo.Size = new System.Drawing.Size(57, 17);
            this.optInativo.TabIndex = 1;
            this.optInativo.TabStop = true;
            this.optInativo.Text = "Inativo";
            this.optInativo.UseVisualStyleBackColor = true;
            this.optInativo.CheckedChanged += new System.EventHandler(this.optInativo_CheckedChanged);
            // 
            // optAtivo
            // 
            this.optAtivo.AutoSize = true;
            this.optAtivo.Location = new System.Drawing.Point(36, 19);
            this.optAtivo.Name = "optAtivo";
            this.optAtivo.Size = new System.Drawing.Size(49, 17);
            this.optAtivo.TabIndex = 0;
            this.optAtivo.TabStop = true;
            this.optAtivo.Text = "Ativo";
            this.optAtivo.UseVisualStyleBackColor = true;
            this.optAtivo.CheckedChanged += new System.EventHandler(this.optAtivo_CheckedChanged);
            // 
            // Cstatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gpbsituacao);
            this.Name = "Cstatus";
            this.Size = new System.Drawing.Size(199, 69);
            this.gpbsituacao.ResumeLayout(false);
            this.gpbsituacao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbsituacao;
        private System.Windows.Forms.RadioButton optInativo;
        private System.Windows.Forms.RadioButton optAtivo;
    }
}
