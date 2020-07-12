using DataBase.Pessoas;
using Entities.Pessoas;


namespace Business.Pessoas {
    public class TipoUsuarioNG {

        private readonly TipoUsuarioBD _bd;
        public TipoUsuarioNG()
        {
            _bd = new TipoUsuarioBD();
        }
        public TipoUsuario BuscarTipoUsuariodoUsuario(int codigo)
        {
            return _bd.BuscarTipoUsuariodoUsuario(codigo);
        }

        public TipoUsuario Buscar(int codigo)
        {
            return _bd.Buscar(codigo);
        }
    }
}
