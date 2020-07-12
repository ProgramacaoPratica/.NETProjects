using System;
using System.Windows.Forms;

namespace InterfaceUser.Modulos
{
    public static class MascaraCampoCodigo
    {
        public static void RetornarMascara(Object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text.Trim().Equals(string.Empty))
                return;
            txt.Text = Int32.Parse(txt.Text).ToString("00000");
        }

        public static void TirarMascara(Object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text.Trim().Equals(string.Empty))
                return;
            txt.Text = Convert.ToInt32(txt.Text.Trim()).ToString();
            txt.Focus();
            txt.Select(0, txt.Text.Length);
        }

        public static void ApenasValoresNumericos(Object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
                e.Handled = true;
        }

        public static void AplicarEventos(TextBox txt)
        {
            txt.Enter += TirarMascara;
            txt.Leave += RetornarMascara;
            txt.KeyPress += ApenasValoresNumericos;
        }
    }
}
