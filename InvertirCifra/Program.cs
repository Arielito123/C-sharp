using System;

namespace InvertirCifra
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int numero, uni, dec, aux,cent;


            Console.WriteLine("Ingrese Un Numero de dos cifras para poder Invertirlo");
            numero = int.Parse(Console.ReadLine());
            Console.Clear();

           
            uni = Unidad(numero);//Numero lo haremos pasar por modulo para separar el resto
            dec = Decena(numero);//el numero Ingresado se divira por 10 para que el numero se haga mas chico 
            aux = (uni * 10) + dec;//la unidad se multiplicara por 10 y se suma la decena para invertir el numero selecionado
            Console.WriteLine(" Su Numero elejido es:"+ numero);
            Console.WriteLine(" Su Numero Inverso es:"+aux);//Lanzamos por leyenda el Numero al Inverso

            Console.ReadKey();

        }




        static int Unidad(int n1)//esta funcion sacara el resto de un numero;
        {
            int unidad;//creamos la variable unidad

            unidad = n1 % 10;//proceso para siempre sacar restos

            return unidad;//retornamos el valor
        }



        static int Decena(int n1)//esta funcion dividira n1 por 10
        {
            int dec;//variable para la decena

            dec = n1 / 10;//proceso para dividir el numero por 10

            return dec;//retornamos el valor
        }


    }
}
