using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] letras = new char[10];
            int i;
            

            Console.WriteLine("Coloque 10 letras, e nós juntaremos em uma palavra");
            for(i = 0; i< 10; i++)
            {
                letras[i] = char.Parse(Console.ReadLine());
            }
            Console.WriteLine(letras);
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine(letras[i]);
            }
        }
    }
}