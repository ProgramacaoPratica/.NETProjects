using System;
using System.Globalization;

namespace Cauculo {
    class Prestacao {

        public DateTime Dta_Vencimento { get; set; }
        public double Montante { get; set; }

        public Prestacao(DateTime dta_Vencimento, double montante)
        {
            Dta_Vencimento = dta_Vencimento;
            Montante = montante;
        }

        public override string ToString()
        {

            return Dta_Vencimento.ToString("dd/MM/yyy")
               + "  R$- "
                + Montante.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
