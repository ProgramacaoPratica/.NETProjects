using Entities.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Pessoas {
    public class Usuario {

        public Usuario()
        {
            this.TipoUsuario = new TipoUsuario();
        }

        public string Nome { get; set; }
        public int Codigo { get; set; }
        public TipoUsuario TipoUsuario { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public Status Status { get; set; }
        public DateTime dtAlteracao { get; set; }
        public int CodigoUsrAlteracao { get; set; }


    }
}
