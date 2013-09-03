using System;

namespace Tarea
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string var;
			int num1=0, num2=0, num3=0;
			Console.Write ("Hola, ingresa un nombre: ");
			var=Console.ReadLine();
			Console.WriteLine("{0}, Gracias esta es una prueba de programa", var);
			Console.WriteLine("Ahora ingresa dos numeros: ");

			Console.Write ("1er numero: ");
			num1=Convert.ToInt32(Console.ReadLine());

			Console.Write ("2do numero: ");
			num2=Convert.ToInt32(Console.ReadLine());
			num3=num1+num2;
			Console.WriteLine("Los numeros que usted ingresó son: {0} y {1}, la suma es: {2}", num1, num2, num3);

		}
	}
}
