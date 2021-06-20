using System;
using Entities;

namespace static_members
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Qual é a cotação do dólar? ");
			double cota = double.Parse(Console.ReadLine());
			Console.Write("Quantos dólares você vai comprar? ");
			double valor = double.Parse(Console.ReadLine());

			Console.WriteLine("Valor a ser pago em reais = " + ConversorDeMoedas.Dolar(cota, valor).ToString("F2"));

			Console.ReadLine();
		}
	}
}
