using System;
using Entities;

namespace class_ex1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Entre com a altura e largura do retangulo:");
			double altura = double.Parse(Console.ReadLine());
			double largura = double.Parse(Console.ReadLine());

			Retangulo ret = new Retangulo(altura, largura);

			Console.WriteLine("AREA = " + ret.Area().ToString("F2") 
				+ "\nPERÍMETRO = " + ret.Perimetro().ToString("F2")
				+ "\nDIAGONAL = " +  ret.Diagonal().ToString("F2"));

			Console.ReadLine();
		}
	}
}
