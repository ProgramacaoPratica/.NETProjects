using Business.Pessoas;
using Entities;
using Entities.Pessoas;
using InterfaceUser.Modulos;
using InterfaceUser.Pesquisa;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace InterfaceUser.Pessoas
{
    public partial class FrmCadUsuario : Form
    {

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
            var lista = new TipoUsuarioNG().ListarEntidadesViewPesquisa();
            if(lista.Count < 1)
            {
                MessageBox.Show("Sem dados para exibir!", this.Text, MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }

            var frmpesquisa = new FrmPesquisaGenerica("Listagem dos tipos de usuários", Entities.Enumeradores.Status.Todos);
            frmpesquisa.lista = lista;
            frmpesquisa.ShowDialog();

            var Iretorno = frmpesquisa.Iretorno;
            if (Iretorno < 1) return;
            txtTipoUsuario.Text= Iretorno.ToString();
            txtTipoUsuario_Validating(txtTipoUsuario, new CancelEventArgs());
            MascaraCampoCodigo.RetornarMascara(txtTipoUsuario, new EventArgs());
            btnBuscaTipoUsuario.Focus();
        }

        private void txtCodigoUsuario_Validated(object sender, EventArgs e)
        {
            if (txtCodigoUsuario.Text.Trim().Equals(string.Empty))
                return;

            var oUsuario = new UsuarioNG().Buscar(Convert.ToInt32(txtCodigoUsuario.Text.Trim()));
            if (oUsuario == null)
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
            txtCodigoUsuario.Text = new UsuarioNG().BuscarProximoCodigo().ToString();
            txtnomeUsuario.Text = string.Empty;
            txtlogincadusuario.Text = string.Empty;
            txtsenhaCadusuario.Text = string.Empty;
            txtTipoUsuario.Text = string.Empty;
            lblmostratipou.Text = string.Empty;
            btnExcluir.Enabled = false;
            oUcsituacao.InicializarSituacao(Entities.Enumeradores.Status.Ativo);
            MascaraCampoCodigo.RetornarMascara(txtCodigoUsuario, new EventArgs());
            MascaraCampoCodigo.RetornarMascara(txtTipoUsuario, new EventArgs());
            isNovo = true;
            Funcoes.selecionarCampo(txtnomeUsuario);
        }

        private void FrmCadUsuario_Load(object sender, EventArgs e)
        {
            btnCancelar_Click(btnCancelar, new EventArgs());
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (!VerificarCampos())
                return;
            var oUsuario = new Usuario();
            var oUsuarioNG = new UsuarioNG();
            oUsuario.Nome = txtnomeUsuario.Text.Trim();
            oUsuario.Login = txtlogincadusuario.Text.Trim();
            oUsuario.Senha = txtsenhaCadusuario.Text.Trim();
            oUsuario.TipoUsuario.Codigo = Convert.ToInt32(txtTipoUsuario.Text.Trim());
            oUsuario.Status = oUcsituacao._status;
            oUsuario.CodigoUsrAlteracao = Sessao.Usuario.Codigo;
            if (isNovo)
            {
                if (oUsuarioNG.Inserir(oUsuario))
                {
                    MessageBox.Show("Registro cadastrado com sucesso", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                }
            }
            else
                    MessageBox.Show("Não foi possível cadastrar este registro", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool VerificarCampos()
        {
            if (txtnomeUsuario.Text.Trim().Equals(string.Empty)){

                MessageBox.Show("Você precisa informar o nome do usuário!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtlogincadusuario.Text.Trim().Equals(string.Empty)){
                MessageBox.Show("Você precisa informar o loguin do usuário!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (txtsenhaCadusuario.Text.Trim().Equals(string.Empty)){
                MessageBox.Show("Você precisa informar a senha do usuário!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtTipoUsuario.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Você precisa informar o tipo do usuário!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return true;
        }

        private void txtTipoUsuario_Validating(object sender, CancelEventArgs e)
        {
            if (txtTipoUsuario.Text.Trim().Equals(string.Empty))
            {
                lblmostratipou.Text = string.Empty;
                return;
            }

            var oTipoUsuario = new TipoUsuarioNG().Buscar(Convert.ToInt32(txtCodigoUsuario.Text.Trim()));
            if (oTipoUsuario == null)
            {
                MessageBox.Show("Tipo de usuário não encontrado!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTipoUsuario.Select();
                return;
            }

            lblmostratipou.Text = oTipoUsuario.Descricao;
        }

        
    }
}
