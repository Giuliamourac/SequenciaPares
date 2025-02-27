using System;

class Program
{
    static void Main(string[] args)
    {
        int numero = 0;

        Console.WriteLine("Digite um número para a listagem de todos dos pares entre este e 0. ");

        numero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Os pares são:");

        for (int i = 0; i <= numero; i++)
        {

            if (i % 2 == 0)
            {

                Console.WriteLine($"{i}");

            }

            else
            {


            }

        }

    }

}