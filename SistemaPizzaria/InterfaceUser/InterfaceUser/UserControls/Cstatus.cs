using System;
using System.Windows.Forms;
using Entities.Enumeradores;

namespace InterfaceUser.UserControls {
    public partial class Cstatus : UserControl {

        public Status _status;
        public Cstatus()
        {
            InitializeComponent();
        }

        private void gpbsituacao_Enter(object sender, EventArgs e)
        {
            if (DesignMode) return;
            InicializarSituacao(Status.Ativo);
        }

        public void InicializarSituacao(Status status)
        {
            if (DesignMode) return;
            _status = status;
            if (status == Status.Ativo)
                optAtivo.Checked = true;
            else
                optInativo.Checked = true;
        }

        private void optAtivo_CheckedChanged(object sender, EventArgs e)
        {
            if (DesignMode) return;
            if (optAtivo.Checked)
                _status = Status.Ativo;
        }

        private void optInativo_CheckedChanged(object sender, EventArgs e)
        {
            if (DesignMode) return;
            if (optInativo.Checked)
                _status = Status.Inativo;
        }
    }
}
