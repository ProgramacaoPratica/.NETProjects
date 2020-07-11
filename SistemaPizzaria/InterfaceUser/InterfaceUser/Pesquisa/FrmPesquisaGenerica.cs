using Entities.Entidades;
using Entities.Enumeradores;
using InterfaceUser.Modulos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InterfaceUser.Pesquisa {
    public partial class FrmPesquisaGenerica : Form {

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

            PreencherLista(lista);

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
    }
}
