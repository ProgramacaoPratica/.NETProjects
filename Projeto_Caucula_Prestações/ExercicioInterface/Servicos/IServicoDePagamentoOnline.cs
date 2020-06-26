
namespace ExercicioInterface.Servicos {
    interface IServicoDePagamentoOnline {

        double Valor_Original(double montante);
        double Juros(double montante, int meses);
    }
}
