using InterfaceUser.Login;
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

            var Frmlogin = new Frmlogin();
            Frmlogin.ShowDialog();
        }
    }
}
