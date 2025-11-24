using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args) 
        {

            int i;
            int a;

            Console.WriteLine("Quantas letras você quer na sua palavra?");
            a = int.Parse(Console.ReadLine());
            char[] letras = new char[a];

            Console.WriteLine("Coloque " + a + " letras, e nós juntaremos em uma palavra");
            for (i = 0; i < a; i++)
            {
                letras[i] = char.Parse(Console.ReadLine());
            }

            Console.WriteLine("A palavra completa é: ");
            Console.WriteLine(letras);
            for (i = 0; i < a; i++)
            {
                int j = i + 1;
                Console.WriteLine("a "+j+"° letra é:"+letras[i]);

            }
        }
    }
}