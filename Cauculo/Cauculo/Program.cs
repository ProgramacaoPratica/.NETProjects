using System;
using System.Globalization;
using Cauculo;

namespace Programa {
    class Program {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre com os dados do contrato: ");
            Console.Write("Número: ");
            int numerocontrato = int.Parse(Console.ReadLine());
            Console.Write("Data: ");
            DateTime data = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy",
            CultureInfo.InvariantCulture);
            Console.WriteLine("Valor do contrato: ");
            double valorcontrato = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre número de prestações: ");
            int nprestacoes = int.Parse(Console.ReadLine());

            Contrato meucontrato = new Contrato(numerocontrato, data, valorcontrato);
            ServicosDeContrato servico = new ServicosDeContrato(new PaypalServico());

            servico.Processa_Contrato(meucontrato, nprestacoes);

            Console.WriteLine();

            Console.WriteLine("PRESTAÇÕES: ");

            foreach (Prestacao prestacao in meucontrato.prestacao)
            {

                Console.WriteLine(prestacao);
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
