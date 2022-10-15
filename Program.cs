using System;
using System.IO;
public class Program{


	class aarray_multidimensional {

		public static void array(int[,] num, double filas) {
			int i;
			Console.Clear();
			for (i=1;i<=filas;i++) {
				Console.WriteLine("");
				Console.WriteLine(num[i-1,0]+" + "+num[i-1,1]+" = "+num[i-1,2]);
			}

			StreamWriter BR = new StreamWriter (@"BRArray.txt");

			for (i=1;i<=filas;i++) {
				Console.WriteLine("");
				BR.WriteLine(num[i-1,0]+" + "+num[i-1,1]+" = "+num[i-1,2]);
			}
			BR.Close ();
		}

		public static void Main(string[] args) {
			
			int columnas;
			int filas;
			int i;
			int j;
			Console.Clear();
			Console.WriteLine("----------------------------------------");
			Console.WriteLine("Bienvenidos a la pesentacion del grupo 2");
			Console.WriteLine("----------------------------------------");
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("Introduce las filas del array multidimensional");
			Console.WriteLine("");
			filas = int.Parse(Console.ReadLine());
			columnas = 3;
			int[,] num = new int[filas,columnas];
			for (i=1;i<=filas;i++) {
				for (j=1;j<=columnas;j++) {
					if ((j==columnas)) {
						num[i-1,j-1] = num[i-1,0] + num[i-1,1];
					} else {
						Console.Clear();
						Console.WriteLine("--------------------------------------------------");
						Console.WriteLine("Introduce un numero para la FILA "+i+" COLUMNA " +j);
						Console.WriteLine("--------------------------------------------------");
						Console.WriteLine("");
						num[i-1,j-1] = int.Parse(Console.ReadLine());
					}
				}
			}
			array(num,filas);
		}

	}
}
