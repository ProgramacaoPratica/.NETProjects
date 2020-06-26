
using System;

namespace Cauculo {
    class ServicosDeContrato {

        private IServicoDePagamentoOnline iservicoDePagamentoOnline;
        public ServicosDeContrato(IServicoDePagamentoOnline iservicoDePagamentoOnline)
        {

            this.iservicoDePagamentoOnline = iservicoDePagamentoOnline;
        }

        public void Processa_Contrato(Contrato contrato, int meses)
        {

            double quotaBasica = contrato.Valor_Total / meses;
            for (int i = 1; i <= meses; i++)
            {
                DateTime data = contrato.Data.AddMonths(i);
                double quota_atualizada = quotaBasica + iservicoDePagamentoOnline.Juros(quotaBasica, i);
                double cota_total = quota_atualizada + iservicoDePagamentoOnline.Valor_Original(quota_atualizada);
                contrato.Add_Prestacao(new Prestacao(data, cota_total));
            }
        }
    }
}
