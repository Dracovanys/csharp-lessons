using System;
using Entities;

namespace constructor
{
	class Program
	{
		static void Main(string[] args)
		{
			ContaBancaria conta = new ContaBancaria();

			Console.Write("Entre o número da conta: ");
			int numConta = int.Parse(Console.ReadLine());
			Console.Write("Entre o titular da conta: ");
			string titular = Console.ReadLine();
			Console.Write("Haverá depósito inicial(s/n)? ");
			char op = char.Parse(Console.ReadLine());

			if (op == 's')
			{
				Console.Write("Entre o valor do depósito inicial: ");
				double depos = double.Parse(Console.ReadLine());

				conta = new ContaBancaria(numConta, titular, depos);
			} else if (op == 'n')
			{
				conta = new ContaBancaria(numConta, titular);
			}

			Console.WriteLine(conta);

			Console.Write("Entre um valor para depósito: ");
			double dep = double.Parse(Console.ReadLine());
			conta.Deposito(dep);

			Console.Write("Entre um valor para saque: ");
			double saque = double.Parse(Console.ReadLine());
			conta.Saque(saque);

			Console.ReadLine();


		}
	}
}
