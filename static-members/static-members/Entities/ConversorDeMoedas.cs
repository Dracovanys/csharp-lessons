namespace Entities
{
	static class ConversorDeMoedas
	{
		public static double Dolar(double cota, double valor)
		{
			return (valor * cota) + (0.06 * (valor * cota));
		}
	}
}
