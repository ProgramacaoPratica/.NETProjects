using InterfaceUser.Login;
using InterfaceUser.Pessoas;
using System;
using System.Windows.Forms;

namespace InterfaceUser {
    public partial class MDIfrm : Form {
        public MDIfrm()
        {
            InitializeComponent();
        }

        private void MDIfrm_Load(object sender, EventArgs e)
        {
            foreach(Control control in Controls)
            {
                if(control is MdiClient)
                {
                    control.BackgroundImage = Properties.Resources.fundo;
                    control.BackgroundImageLayout = ImageLayout.Zoom;
                    break;
                }
            }

            mnsprincipal.Visible = false;
            var Frmlogin = new Frmlogin();
            Frmlogin.ShowDialog();
            if (!Frmlogin.bFlagLogin) Application.Exit();

            mnsprincipal.Visible = true;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void abrirFormulario(Form oFrm)
        {
            oFrm.WindowState = FormWindowState.Normal;
            oFrm.StartPosition = FormStartPosition.Manual;
            oFrm.MdiParent = this;
            oFrm.Top = 0;
            oFrm.Left = 0;
            oFrm.Show();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FrmCadUsuario());
        }
    }
}
