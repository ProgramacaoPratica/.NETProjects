using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities {
    public interface IEntidade {

        int Codigo { get; set; }
       string Descricao { get; set; }
    }
}
