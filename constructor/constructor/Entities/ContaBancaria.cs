using System.Text;

namespace Entities
{
	class ContaBancaria
	{
		public int numConta { get; private set; }
		public string nomeTitular { get; set; }
		public double depositoInicial { get; set; }
		public double saldo { get; private set; }

		public ContaBancaria()
		{
		}

		public ContaBancaria(int numConta, string nomeTitular, double depositoInicial)
		{
			this.numConta = numConta;
			this.nomeTitular = nomeTitular;
			this.depositoInicial = depositoInicial;
			this.saldo = depositoInicial;

		}

		public ContaBancaria(int numConta, string nomeTitular)
		{
			this.numConta = numConta;
			this.nomeTitular = nomeTitular;
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();

			sb.Append("\nINFORMAÇÕES DA CONTA");
			sb.Append("\nNúmero: " + numConta);
			sb.Append("\nTitular: " + nomeTitular);
			sb.Append("\nSaldo: $" + saldo.ToString("F2") + "\n");

			return sb.ToString();
		}

		public void Deposito(double valor)
		{
			saldo += valor;
			System.Console.WriteLine(this);
		}

		public void Saque(double valor)
		{
			saldo -= valor + 5;
			System.Console.WriteLine(this);
		}
	}
}
