using System;
using System.Globalization;

namespace ComprarDolar {
    class Program {
        static void Main(string[] args) {

            Console.Write("Cotacao do dolar: US$ ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dolares voce vai comprar? ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = ConversorDeMoeda.DolarParaReal(quantia, cotacao);
            Console.Write("Valor a ser pago em REAIS com IOF = R$ " + result.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
