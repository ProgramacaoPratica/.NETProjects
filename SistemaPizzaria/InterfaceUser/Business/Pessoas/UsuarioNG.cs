using DataBase.Pessoas;
using Entities.Entidades;
using Entities.Enumeradores;
using Entities.Pessoas;
using System.Collections.Generic;

namespace Business.Pessoas {
    public class UsuarioNG {

        private readonly UsuarioBD _bd;


        public UsuarioNG()
        {
            _bd = new UsuarioBD();
        }

        public List<EntidadeViewPesquisa> ListarEntidadesViewPesquisa(Status status)
        {
            return _bd.ListarEntidadesViewPesquisa(status);
        }


        public List<Usuario> ListarUsuariosAtivos()
        {
            return _bd.ListarUsuariosAtivos();
        }

        public Usuario Buscar(int cod)
        {
            return _bd.Buscar(cod);
        }
    }
}
