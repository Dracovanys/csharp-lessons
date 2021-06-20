using System;

namespace Entities
{
	class Retangulo
	{
		public double largura { get; set; }
		public double altura { get; set; }

		public Retangulo(double altura, double largura)
		{
			this.largura = largura;
			this.altura = altura;
		}

		public override string ToString()
		{
			return "Altura: " + altura + ", Largura: " + largura;
		}

		public double Area()
		{
			return altura * largura;
		}
		public double Perimetro()
		{
			return (largura + altura) * 2;
		}

		public double Diagonal()
		{
			return Math.Sqrt(Math.Pow(largura, 2) + Math.Pow(altura, 2));
		}

	}
}
