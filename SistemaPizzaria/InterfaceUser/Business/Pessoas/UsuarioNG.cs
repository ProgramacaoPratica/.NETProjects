using DataBase.Pessoas;
using Entities.Pessoas;
using System.Collections.Generic;

namespace Business.Pessoas {
    public class UsuarioNG {

        private readonly UsuarioBD _bd;

        
        public UsuarioNG()
        {
            _bd = new UsuarioBD();
        }
        
        public List<Usuario> ListarUsuarios()
        {
            return _bd.ListarUsuarios();
        }

        

    }
}
