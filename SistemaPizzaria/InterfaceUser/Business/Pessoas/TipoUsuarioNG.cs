using DataBase.Pessoas;
using Entities.Entidades;
using Entities.Pessoas;
using System.Collections.Generic;

namespace Business.Pessoas {
    public class TipoUsuarioNG {

        private readonly TipoUsuarioBD _bd;
        public TipoUsuarioNG()
        {
            _bd = new TipoUsuarioBD();
        }

        public List<EntidadeViewPesquisa> ListarEntidadesViewPesquisa()
        {
            return _bd.ListarEntidadesViewPesquisa();
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
