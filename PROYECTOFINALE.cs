using System;
using System.Collections.Generic;

namespace Proyecto
{
    
    public class Program
    {
        
        

        public static int idLlamada = 1;
        static void Main(string[] args)
        {
            Console.Clear();
                Console.WriteLine(" ");
                Console.WriteLine("|---------------------------------------------------------------------------|"); 
                Console.WriteLine("|                     *******PRIVACY GROUP 2 WARNING*******                 |");
                Console.WriteLine("|      INFORMATION COTAINED IN THIS SYSTEM WITH  RESPECT TO GROUP 2 AND     |");
                Console.WriteLine("|      VERIZON GUATEMALA, SERVICES IS SUBJECT TO THE PRIVACY ACT OFF        |");
                Console.WriteLine("|      2022. PERSONAL INFORMATION CONTAINED IN THIS SYSTEM MAY BE USED      |");
                Console.WriteLine("|      ONLY BY AUTHORIZED PERSON IN THE CONDUCT OF OFFICIAL PROJECT ANY     |");
                Console.WriteLine("|      INDIVIDUAL RESPONSIBLE FOR UNATHORIZED  DISCLOSURE OR MISUSE OF      |");
                Console.WriteLine("|      PERSONAL INFORMATION MAY BE SUBJECT TO FINES OF UP TO 15 POINTS      |");
                Console.WriteLine("|---------------------------------------------------------------------------|");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("press ENTER to continue......      ");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("| @            @  @@@@@@@@   @@@@@@@@     @   @@@@@@@@@@      @@@@       @@       @ |");
                Console.WriteLine("|  @          @   @          @       @    @          @      @@    @@     @ @      @ |");
                Console.WriteLine("|   @        @    @          @       @    @         @      @        @    @  @     @ |");
                Console.WriteLine("|    @      @     @@@@       @ @ @ @ @    @       @        @        @    @   @    @ |");
                Console.WriteLine("|     @    @      @          @    @       @     @          @        @    @    @   @ |");
                Console.WriteLine("|      @  @       @          @     @      @   @            @@     @@     @     @  @ |");
                Console.WriteLine("|       @         @@@@@@@    @      @     @   @@@@@@@@@      @@@@@       @      @ @ |");
                Console.WriteLine("|-----------------------------------------------------------------------------------|");
                Console.WriteLine("|       *************************CUSTOMER INTERFACE**************************       |");
                Console.WriteLine("|                          VERIZON NETWORK LEGACY SYSTEM                            |");
                Console.WriteLine("|                             ALGORITHMS FINAL PROJECT                              |");
                Console.WriteLine("|-----------------------------------------------------------------------------------|");
                Console.WriteLine(" ");
                Console.WriteLine("Press ENTER to continue......      ");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("|-----------------------------------------------------------------------------------|");
                Console.WriteLine("|       *************************CUSTOMER INTERFACE**************************       |");
                Console.WriteLine("|                          VERIZON NETWORK LEGACY SYSTEM                            |");
                Console.WriteLine("|                             ALGORITHMS FINAL PROJECT                              |");
                Console.WriteLine("|-----------------------------------------------------------------------------------|");
                Console.WriteLine("|----------------------------------------|"); 
                Console.WriteLine("|                                        |"); 
                Console.WriteLine("|       CUSTOMERS DATA BASE              |"); 
                Console.WriteLine("|----------------------------------------|"); 
                Console.WriteLine(" ");
                Console.ReadKey();

                     Console.Clear();
                    Console.WriteLine("|--------------------------------------------------|");
                    Console.WriteLine("|  **************CUSTOMER INTERFACE**************  |");
                    Console.WriteLine("|--------------------------------------------------|");
                    Console.WriteLine("|                CUSTOMER SELECTED                 |");
                    Console.WriteLine("|          Carlos Enrique Poggio Morales           |");
                    Console.WriteLine("|--------------------------------------------------|");
                    Console.WriteLine("Press Enter to download data....."); 
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Press Enter to Print Invoice.....");
                    Console.ReadKey();
                    Console.Clear();
                Console.WriteLine("|--------------------------------------------------|");
                Console.WriteLine("|          Carlos Enrique Poggio Morales           |");
                Console.WriteLine("|--------------------------------------------------|");  

        

            List<LlamadasModelo> listaLllamadas = new List<LlamadasModelo>();
            LlamadasModelo nuevaLlamada = CrearLlamada();
            listaLllamadas.Add(nuevaLlamada);
            nuevaLlamada = CrearLlamada();
            listaLllamadas.Add(nuevaLlamada);
            nuevaLlamada = CrearLlamada();
            listaLllamadas.Add(nuevaLlamada);
            nuevaLlamada = CrearLlamada();
            listaLllamadas.Add(nuevaLlamada);
            nuevaLlamada = CrearLlamada();
            listaLllamadas.Add(nuevaLlamada);
            nuevaLlamada = CrearLlamada();
            listaLllamadas.Add(nuevaLlamada);
            nuevaLlamada = CrearLlamada();
            listaLllamadas.Add(nuevaLlamada);
            nuevaLlamada = CrearLlamada();
            listaLllamadas.Add(nuevaLlamada);
            nuevaLlamada = CrearLlamada();
            listaLllamadas.Add(nuevaLlamada);


           
            Console.WriteLine("|  No.  ||   DIAL TO   ||   CALL TYPE\t\t||  MINUTES     ||   FARE\t||   CALL PRICE\t|");

            foreach (LlamadasModelo llamada in listaLllamadas)
            {
                if (llamada.CallType == "Internacional")
                {
                    Console.WriteLine($"|  {llamada.Id}    ||  {llamada.DialTo}   ||   {llamada.CallType}\t||   {llamada.Minutes}\t\t||   {llamada.Fare}\t||  {llamada.CallPrice}\t|");
                }
                else
                {
                    Console.WriteLine($"|  {llamada.Id}    ||  {llamada.DialTo }   ||   {llamada.CallType}\t\t||   {llamada.Minutes}\t\t||   {llamada.Fare}\t||  {llamada.CallPrice}\t|");
                }
                
            }
        }
        public static LlamadasModelo CrearLlamada()
        {
            LlamadasModelo nuevaLlamada = new LlamadasModelo();
            Random rnd = new Random();
            nuevaLlamada.Id = idLlamada;
            nuevaLlamada.DialTo = rnd.Next(33000000, 77000000);
            nuevaLlamada.Minutes = rnd.Next(0, 99);
            int tipoLlamada = rnd.Next(0, 2);
            switch (tipoLlamada)
            {
                case 0:
                    nuevaLlamada.CallType = "Internacional";
                    if(nuevaLlamada.Minutes > 7)
                    {
                        nuevaLlamada.Fare = 5.08;
                    }
                    else
                    {
                        nuevaLlamada.Fare = 10.48;
                    }
                    nuevaLlamada.CallPrice = nuevaLlamada.Minutes * nuevaLlamada.Fare;
                    break;
                case 1:
                    nuevaLlamada.CallType = "Nacional";
                    if (nuevaLlamada.Minutes > 10)
                    {
                        nuevaLlamada.Fare = 0.48;
                    }
                    else
                    {
                        nuevaLlamada.Fare = 3.50;
                    }
                    nuevaLlamada.CallPrice = nuevaLlamada.Minutes * nuevaLlamada.Fare;
                    break;
                case 2:
                    nuevaLlamada.CallType = "Internacional";
                    if (nuevaLlamada.Minutes > 25)
                    {
                        nuevaLlamada.Fare = 0.40;
                    }
                    else
                    {
                        nuevaLlamada.Fare = 0;
                    }
                    nuevaLlamada.CallPrice = nuevaLlamada.Minutes * nuevaLlamada.Fare;
                    break;

            } 
                
            idLlamada++;
            return nuevaLlamada;             

       }

    }

}

   



    
    



