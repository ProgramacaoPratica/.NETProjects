using System;
using System.Collections.Generic;

namespace Cauculo {
    class Contrato {
        public int Numero { get; set; }
        public DateTime Data { get; set; }
        public double Valor_Total { get; set; }
        public List<Prestacao> prestacao { get; set; }

        public Contrato(int numero, DateTime data, double valor_Total)
        {
            Numero = numero;
            Data = data;
            Valor_Total = valor_Total;
            prestacao = new List<Prestacao>();
        }

        public void Add_Prestacao(Prestacao _prestacao)
        {
            prestacao.Add(_prestacao);
        }
    }
}
