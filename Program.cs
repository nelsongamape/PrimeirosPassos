using System;

namespace PrimeirosPassos
{
    class Program
    {
        static void Main(string[] args)
        {
            {
            for( int i=10; i<=15; i++)
            Console.WriteLine("For OK " +i);
            }
        
            int contador = 1;
            while (contador <= 5)
                {Console.WriteLine("While OK "+ contador);
                 contador++;              
                }

            double j = 3;
            do
                {
                    Console.WriteLine("Do OK " +j);
                    j = j*3;
                } while (j<=90);
            Console.WriteLine("Do OK " +j);
        }
    }
}
