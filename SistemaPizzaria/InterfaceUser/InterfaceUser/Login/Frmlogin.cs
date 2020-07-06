using System;
using Business.Pessoas;
using System.Reflection;
using System.Windows.Forms;
using Entities.Sistema;

namespace InterfaceUser.Login {
    public partial class Frmlogin : Form {
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
            var lista = new UsuarioNG().ListarUsuarios();
            if (lista.Count > 0)
            {
                foreach (var item in lista)
                {
                    cmbusuarios.Items.Add(new ComboBoxItemUsuario(item.Login, item.Codigo, item.Senha));
                }
            }


        }
    }
}
