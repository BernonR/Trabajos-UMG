using System;

	class aarray_multidimensional {

		static void array(int[,] num, double filas) {
			int i;
			for (i=1;i<=filas;i++) {
				Console.WriteLine(num[i-1,0]+" + "+num[i-1,1]+" = "+num[i-1,2]);
			}
		}

		static void Main(string[] args) {
			int columnas;
			int filas;
			int i;
			int j;
			Console.WriteLine("Introduce las filas del array multidimensional");
			filas = int.Parse(Console.ReadLine());
			columnas = 3;
			int[,] num = new int[filas,columnas];
			for (i=1;i<=filas;i++) {
				for (j=1;j<=columnas;j++) {
					if ((j==columnas)) {
						num[i-1,j-1] = num[i-1,0]+num[i-1,1];
					} else {
						Console.WriteLine("Introduce un numero para la FILA "+i+" COLUMNA "+j);
						num[i-1,j-1] = int.Parse(Console.ReadLine());
					}
				}
			}
			array(num,filas);
		}

	}
