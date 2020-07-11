using Business.Pessoas;
using InterfaceUser.Pesquisa;
using System;
using System.Windows.Forms;

namespace InterfaceUser.Pessoas {
    public partial class FrmCadUsuario : Form {
        public FrmCadUsuario()
        {
            InitializeComponent();
        }

        private void btnbscusuario_Click(object sender, EventArgs e)
        {
            var lista = new UsuarioNG().ListarEntidadesViewPesquisa(Entities.Enumeradores.Status.Todos);
            // Verifica se a lista está vazia
            if (lista.Count < 1)
            {
                MessageBox.Show("Sem dados serem exibidos!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Passar a lista para o formulário de pesquisa
            var FrmPesquisa = new FrmPesquisaGenerica("Listagem de Usuários", Entities.Enumeradores.Status.Todos);
            FrmPesquisa.lista = lista;
            FrmPesquisa.ShowDialog();
        }

        private void btnBuscaTipoUsuario_Click(object sender, EventArgs e)
        {
            
        }

       
    }
}
