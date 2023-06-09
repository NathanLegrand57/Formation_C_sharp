// See https://aka.ms/new-console-template for more information
using System;


class Program
{
    static void Main(string[] args)
    {
        /* Console.WriteLine("Entrez un chiffre supérieur à 0 et inférieur à 10");
        Random rnd = new Random();
        int valid = rnd.Next(0, 9);
        int i = 0;
        int chiffre = Convert.ToInt32(Console.ReadLine());
        while (chiffre != valid && i < 4)
        {
            if (chiffre > 10)
            {
                Console.WriteLine("En-dessous de 10 !!!!");
                chiffre = Convert.ToInt32(Console.ReadLine());
                i++;
            }
            else if (chiffre <= 0)
            {
                Console.WriteLine("Au-dessus de 0 !!!!");
                chiffre = Convert.ToInt32(Console.ReadLine());
                i++;
            }
            else
            {
                Console.WriteLine("Essaie encore !");
                chiffre = Convert.ToInt32(Console.ReadLine());
                i++;
            }
            if (i == 4)
            {
                Console.WriteLine("Trop de tentatives !");
                Console.WriteLine($"Le chiffre était {valid}");
            }

        }
        if (chiffre == valid)
        {
            Console.WriteLine("Bingo !");
            Console.WriteLine($"Le chiffre était {valid}");
        } */

        Console.WriteLine(multiple(5,5));

        static int multiple(int x, int y){
            return x*y;
        }
    }
}

