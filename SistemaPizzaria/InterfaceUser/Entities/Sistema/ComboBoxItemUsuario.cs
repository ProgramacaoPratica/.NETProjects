namespace Entities.Sistema {
    public class ComboBoxItemUsuario {

        public string login;
        public int codigo;
        public string senha;

        public ComboBoxItemUsuario(string login, int codigo, string senha)
        {
            this.login = login;
            this.codigo = codigo;
            this.senha = senha;
        }

        public override string ToString()
        {
            return login;
        }
    }
}
