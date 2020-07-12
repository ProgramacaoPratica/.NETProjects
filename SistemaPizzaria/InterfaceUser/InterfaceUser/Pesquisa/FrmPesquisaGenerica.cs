using Entities.Entidades;
using Entities.Enumeradores;
using InterfaceUser.Modulos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace InterfaceUser.Pesquisa
{
    public partial class FrmPesquisaGenerica : Form
    {

        public List<EntidadeViewPesquisa> lista = new List<EntidadeViewPesquisa>();
        public int Iretorno = 0;
        public FrmPesquisaGenerica(string strTitutlo, Status status)
        {
            InitializeComponent();
            this.Text = strTitutlo;
            if (status == Status.Ativo)
                optsomenteativos.Checked = true;
            else if (status == Status.Inativo)
                optsomenteinativos.Checked = true;
            else opttodos.Checked = true;

        }

        private void FrmPesquisaGenerica_Load(object sender, EventArgs e)
        {
            var form = new Form()
            {
                FormBorderStyle = FormBorderStyle.None,
                ShowInTaskbar = false,
                StartPosition = FormStartPosition.CenterScreen,
                TopMost = true,
                Top = 0,
                Left = 0
            };

            LimparCampos();
            PreencherLista(lista);

        }

        public void LimparCampos()
        {
            txtbuscapesquisa.Text = string.Empty;
            Iretorno = 0;
        }

        private void PreencherLista(List<EntidadeViewPesquisa> list)
        {
            lvllistagem.Clear();
            lvllistagem.View = View.Details;

            lvllistagem.Columns.Add("Código", 80, HorizontalAlignment.Right);
            lvllistagem.Columns.Add("Descrição", 280, HorizontalAlignment.Left);

            foreach (var item in list)
            {
                if (!opttodos.Checked)
                {
                    if (optsomenteativos.Checked && item.Status != Entities.Enumeradores.Status.Ativo)
                        continue;
                    else if (optsomenteinativos.Checked && item.Status != Entities.Enumeradores.Status.Inativo)
                        continue;
                }

                var linha = new string[2];
                linha[0] = item.Codigo.ToString();
                linha[1] = item.Descricao.ToString();
                var itemX = new ListViewItem(linha);
                lvllistagem.Items.Add(itemX);
            }

            Funcoes.ListViewColor(lvllistagem);
        }

        private void lvllistagem_DoubleClick(object sender, EventArgs e)
        {
            btn_confirmar_pesquisa_Click(btn_confirmar_pesquisa, new EventArgs());
        }

        private void btn_sair_pesquisa_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_confirmar_pesquisa_Click(object sender, EventArgs e)
        {
            if (lvllistagem.SelectedIndices.Count <= 0)
                return;

            var iSelectedIndex = Convert.ToInt32(lvllistagem.SelectedIndices[0]);
            if (iSelectedIndex >= 0)
            {
                Iretorno = Convert.ToInt32(lvllistagem.Items[iSelectedIndex].Text);
                btn_sair_pesquisa_Click(btn_sair_pesquisa, new EventArgs());
            }
        }

        private void opttodos_CheckedChanged(object sender, EventArgs e)
        {
            if (!opttodos.Checked) return;
            LimparCampos();
            PreencherLista(lista);  
        }

        private void optsomenteativos_CheckedChanged(object sender, EventArgs e)
        {
            if (!optsomenteativos.Checked) return;
            LimparCampos();
            PreencherLista(lista);
        }

        private void optsomenteinativos_CheckedChanged(object sender, EventArgs e)
        {
            if (!optsomenteinativos.Checked) return;
            LimparCampos();
            PreencherLista(lista);
        }

        private void txtbuscapesquisa_TextChanged(object sender, EventArgs e)
        {
            if (txtbuscapesquisa.Text.Trim().Equals(string.Empty))
                return;

            var listresult = new List<EntidadeViewPesquisa>(from p in lista where p.Descricao.ToLower().Contains(txtbuscapesquisa.Text.Trim().ToLower()) select p);
            PreencherLista(lista);
        }
    }
}
