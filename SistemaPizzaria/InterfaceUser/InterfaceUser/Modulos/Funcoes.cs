using System.Windows.Forms;

namespace InterfaceUser.Modulos {
    public static class Funcoes {

        public static void ListViewColor(ListView lvl)
        {
            foreach (ListViewItem item in lvl.Items)
            {
                if ((item.Index % 2) == 0)
                    item.BackColor = System.Drawing.Color.White;
                else
                    item.BackColor = System.Drawing.Color.LightBlue;
            }
        }

        public static void selecionarCampo(TextBox textBox)
        {
            textBox.Focus();
            textBox.Select();
        }
    }
}
