using System;
using Business.Pessoas;
using System.Reflection;
using System.Windows.Forms;
using Entities.Sistema;
using Entities;

namespace InterfaceUser.Login {
    public partial class Frmlogin : Form {

        public bool bFlagLogin;
        public Frmlogin()
        {
            InitializeComponent();
        }

        private void Frmlogin_Load(object sender, EventArgs e)
        {
            var version = Assembly.GetExecutingAssembly().GetName().Version;
            lblversao.Text = string.Format(lblversao.Text, version.Major, version.Minor, version.Build, version.Revision);

            CarregarUsuarios();

        }

        private void CarregarUsuarios()
        {
            var lista = new UsuarioNG().ListarUsuariosAtivos();
            if (lista.Count > 0)
            {
                foreach (var item in lista)
                {
                    cmbusuarios.Items.Add(new ComboBoxItemUsuario(item.Login, item.Codigo, item.Senha));
                }
            }


        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            if (cmbusuarios.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Você deve selecionar o login para acessar o sistema!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtsenha.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Você deve informar sua senha para acessar o sistema!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var item = (ComboBoxItemUsuario)cmbusuarios.SelectedItem;
            if(item.senha != txtsenha.Text.Trim())
            {
                MessageBox.Show("A senha informada está incorreta!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bFlagLogin = true;

            Sessao.Usuario = new Entities.Entidade(item.codigo, item.login);
            Sessao.TipoUsuario = new TipoUsuarioNG().BuscarTipoUsuariodoUsuario(item.codigo);

            this.Close();
        }
    }
}
