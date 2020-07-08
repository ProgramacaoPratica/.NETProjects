using Entities.Pessoas;
namespace Entities {
    public class Sessao {
        public static Entidade Usuario { get; set; }
        public static TipoUsuario TipoUsuario { get; set; }
        private static Sessao Instancia;

        public static Sessao GetInstancia {

            get {
                if (Instancia == null)
                {
                    Instancia = new Sessao();
                }
                return Instancia;
            }
        }

    }
}
