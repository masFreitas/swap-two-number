using System;

namespace TesteMateus
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, temp;
            Console.WriteLine("Informe um numero inteiro");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe outro numero inteiro");
            n2 = int.Parse(Console.ReadLine());

            temp = n1;
            n1 = n2;
            n2 = temp;

            Console.WriteLine("SWAP {0} {1}", n1, n2);
        }
    }
}
