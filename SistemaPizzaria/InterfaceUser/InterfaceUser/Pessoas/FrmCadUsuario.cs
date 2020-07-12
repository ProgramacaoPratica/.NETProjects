using Business.Pessoas;
using InterfaceUser.Modulos;
using InterfaceUser.Pesquisa;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace InterfaceUser.Pessoas {
    public partial class FrmCadUsuario : Form {

        private bool isNovo;
        public FrmCadUsuario()
        {
            InitializeComponent();
            MascaraCampoCodigo.AplicarEventos(txtCodigoUsuario);
            MascaraCampoCodigo.AplicarEventos(txtTipoUsuario);
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

            var iRetorno = FrmPesquisa.Iretorno;
            if (iRetorno < 1) return;

            txtCodigoUsuario.Text = iRetorno.ToString();
            txtCodigoUsuario_Validated(txtCodigoUsuario, new CancelEventArgs());
            btnBuscaTipoUsuario.Focus();
        }

        private void btnBuscaTipoUsuario_Click(object sender, EventArgs e)
        {
            
        }

        private void txtCodigoUsuario_Validated(object sender, EventArgs e)
        {
            if (txtCodigoUsuario.Text.Trim().Equals(string.Empty))
                return;

            var oUsuario = new UsuarioNG().Buscar(Convert.ToInt32(txtCodigoUsuario.Text.Trim()));
            if(oUsuario == null)
            {
                btnExcluir.Enabled = false;
                return;
            }

            isNovo = false;
            txtnomeUsuario.Text = oUsuario.Nome;
            txtlogincadusuario.Text = oUsuario.Login;
            txtsenhaCadusuario.Text = oUsuario.Senha;
            txtTipoUsuario.Text = oUsuario.TipoUsuario.Codigo.ToString();

            txtTipoUsuario_Validating(txtCodigoUsuario, new CancelEventArgs());
            MascaraCampoCodigo.RetornarMascara(txtTipoUsuario, new EventArgs());
            MascaraCampoCodigo.RetornarMascara(txtCodigoUsuario, new EventArgs());
            oUcsituacao.InicializarSituacao(oUsuario.Status);
            btnExcluir.Enabled = true;
        }

        public void LimparCampos()
        {

        }

        private void FrmCadUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

        }

        private void txtTipoUsuario_Validating(object sender, CancelEventArgs e)
        {
            if (txtTipoUsuario.Text.Trim().Equals(string.Empty))
            {
                lblmostratipou.Text = string.Empty;
                return;
            }

            var oTipoUsuario = new TipoUsuarioNG().Buscar(Convert.ToInt32(txtCodigoUsuario.Text.Trim()));
            if(oTipoUsuario == null)
            {
                MessageBox.Show("Tipo de usuário não encontrado!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTipoUsuario.Select();
                return;
            }

            lblmostratipou.Text = oTipoUsuario.Descricao;
        }
    }
}
