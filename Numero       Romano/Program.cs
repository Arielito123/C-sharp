using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros_Romanos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*M=1000
              C=500
              D=100
              L=50
              X=10
              V=10
              I=1*/
            while (true) { 
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();

            int numero, unidades, centenas, decenas, millar;

            Console.WriteLine("Ingrese un numero entre 1 y 4 digitos, hasta el 3999 Por favor para asi luego convertilos a Romano");
            numero = int.Parse(Console.ReadLine());

            unidades = numero % 10; numero = numero / 10;/*Proceso para separar  la variable numero y obtener la unidad*/
            decenas = numero % 10; numero = numero / 10;/*Proceso para separar  la variable numero y obtener la decena*/
            centenas = numero % 10; numero = numero / 10;/*Proceso para separar  la variable numero y obtener la centena*/
            millar = numero % 10; numero = numero / 10;/*Proceso para separar  la variable numero y obtener la millar*/

            switch (millar)//un seleccion para millar
            {
                case 1:
                    Console.Write("M");//del 1000 al 3000
                    break;
                case 2:
                    Console.Write("MM");
                    break;

                case 3:
                    Console.Write("MMM");
                    break;
            }

            switch (centenas)//un seleccion para la centena
            {//del 100 al 900

                case 1:
                    Console.Write("C");
                    break;

                case 2:
                    Console.Write("CC");
                    break;

                case 3:
                    Console.Write("CCC");
                    break;

                case 4:
                    Console.Write("CD");
                    break;


                case 5:
                    Console.Write("D");
                    break;

                case 6:
                    Console.Write("DC");
                    break;

                case 7:
                    Console.Write("DCC");
                    break;

                case 8:
                    Console.Write("DCCC");
                    break;

                case 9:
                    Console.Write("CM");
                    break;
            }
            switch (decenas)//un seleccion para la decena
            {//del 10 al 90
                case 1:
                    Console.Write("X");
                    break;

                case 2:
                    Console.Write("XX");
                    break;

                case 3:
                    Console.Write("XXX");
                    break;

                case 4:
                    Console.Write("XL");
                    break;

                case 5:
                    Console.Write("L");
                    break;

                case 6:
                    Console.Write("LX");
                    break;

                case 7:
                    Console.Write("LXX");
                    break;

                case 8:
                    Console.Write("LXXX");
                    break;

                case 9:
                    Console.Write("XC");
                    break;
            }

            switch (unidades)//para la unidad
            {
                case 1:
                    Console.Write("I");
                    break;

                case 2:
                    Console.Write("II");
                    break;

                case 3:
                    Console.Write("III");
                    break;

                case 4:
                    Console.Write("IV");
                    break;

                case 5:
                    Console.Write("V");
                    break;

                case 6:
                    Console.Write("VI");
                    break;

                case 7:
                    Console.Write("VII");
                    break;

                case 8:
                    Console.Write("VIII");
                    break;

                case 9:
                    Console.Write("IX");
                    break;
            }
                

                Console.ReadKey();
        }


            }
        }
}
