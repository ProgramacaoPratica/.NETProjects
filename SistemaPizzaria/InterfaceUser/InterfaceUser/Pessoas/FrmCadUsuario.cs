using Business.Pessoas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }

        private void btnBuscaTipoUsuario_Click(object sender, EventArgs e)
        {
            
        }
    }
}
