using System;

namespace lab4ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Ex 6 dificultate ridicata
                Scrieti o functie recursiva care va calcula al n-lea element din sirul lui
                Fibonacci, n fiind citit de la tastatura, apelati-o si afisati-I rezultatul
             */

            //Sir fibonacci: fiecare numar din sir => din suma celorlalte 2 numere fibo 

            Console.WriteLine("introduceti N");
            int n = int.Parse(Console.ReadLine());


            Console.WriteLine(GetFiboNthElem(n-1));
        }

        static int GetFiboNthElem(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            return GetFiboNthElem(n - 1) + GetFiboNthElem(n - 2);
        }
    }
}
