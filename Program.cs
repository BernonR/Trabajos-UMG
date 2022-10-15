using System;
using System.IO;
public class Program{


	class aarray_multidimensional {

		public static void array(string[,] num, double filas) {
			int i;
			for (i=1;i<=filas;i++) {
				Console.WriteLine(num[i-1,0]+" + "+num[i-1,1]+" = "+num[i-1,2]);
			}

			StreamWriter BR = new StreamWriter (@"BRArray.txt");

			for (i=1;i<=filas;i++) {
				Console.WriteLine(num[i-1,0]+" + "+num[i-1,1]+" = "+num[i-1,2]);

				BR.WriteLine(num[i-1,0]+" + "+num[i-1,1]+" = "+num[i-1,2]);
			}
			BR.Close ();
		}

		public static void Main(string[] args) {
			
			int columnas;
			int filas;
			int i;
			int j;
			
			Console.WriteLine("");
			Console.WriteLine("Introduce las filas del array multidimensional");
			Console.WriteLine("");
			filas = int.Parse(Console.ReadLine());
			columnas = 3;
			string[,] num = new string[filas,columnas];
			for (i=1;i<=filas;i++) {
				for (j=1;j<=columnas;j++) {
					if ((j==columnas)) {
						num[i-1,j-1] = num[i-1,0] + num[i-1,1];
					} else {
						Console.WriteLine("Introduce un numero para la FILA "+i+" COLUMNA " +j);
						num[i-1,j-1] = (Console.ReadLine());
					}
				}
			}
			array(num,filas);
		}

	}
}
