using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaMenorMetodo
{
    class Program
    {
        static void Main(string[] args)
        {
      
            int[] vec=new int[10];//declaramos vector de enteros 10 posiciones
            int[] vec1 = new int[10];//declaramos vector de enteros 10 posiciones
            int suma = 0;//variable donde alojaremos el metodo de la suma

            for (int i = 0; i < 10; i++) 
            {
                Console.WriteLine(" Cargar el vector "+i);//leyenda con la carga del vec1
                vec[i] = int.Parse(Console.ReadLine());//parceamos el vec1

                Console.WriteLine(" Cargar el vector1 " + i);//leyenda con la carga del vec2
                vec1[i] = int.Parse(Console.ReadLine());//parceamos el vec2

            }

            suma =SumaMenor(vec, vec1);// a nuestra variable suma le asignamos el metodo y le pasamos por referencia
            //vec 1 y vec2 para que los sume

            Console.WriteLine("La suma de los numeros menores del vector 1 y 2 es: "+suma);//leyenda con el resultado

            Console.ReadKey();//una pausa en el sistema para que no se cierre el programa

        }

        static int SumaMenor(int[] vec1, int[] vec2)//creamos un metodo que devuelve un entero mediante dos vectores por referencia 
        {
            int Menor1 = vec1[0], Menor2 = vec2[0], Suma = 0;//cargamos las variable nesesarias para encontrar el menor de
            // ambos vectores y sumarlos
            for (int i = 0; i < 10; i++) //ciclo for para recorrer el vector 1 y vector 2
            {
                if (vec1[i] < Menor1)//preguntamos si vec1 en la posicion i es menor 
                {
                    Menor1 = vec1[i];//entonces a menor le asignamos el vector1 mas chiquito que encontramos  
                }

                if (vec2[i] < Menor2)//preguntamos si vec2 en la posicion i es menor 
                {
                    Menor2 = vec2[i];//entonces a menor le asignamos el vector1 mas chiquito que encontramos  
                }

            }

            Suma = Menor1 + Menor2;//sumamos los dos menores encontrado en cada vector 1 y 2
            return Suma;//retornamos un entero llamado suma

        }
    }
}
