namespace Cauculo {
    class PaypalServico : IServicoDePagamentoOnline {

        private const double Percent = 0.02;
        private const double PercentMes = 0.01;

        public double Juros(double montante, int meses)
        {

            return montante * PercentMes * meses;
        }

        public double Valor_Original(double montante)
        {

            return montante * Percent;
        }
    }
}