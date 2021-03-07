using System;

namespace SomaSimples
{
	class Program
	{
		static void Main(string[] args)
		{
			int A, B, soma;

			Console.Write("Digite o primeiro numero: ");
			A = int.Parse(Console.ReadLine());
			Console.Write("Digite o segundo numero: ");
			B = int.Parse(Console.ReadLine());

			soma = A + B;

			Console.WriteLine("SOMA = " + soma);

			Console.ReadLine();
		}
	}
}