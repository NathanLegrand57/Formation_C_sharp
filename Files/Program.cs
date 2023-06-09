using System.IO;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        // string filepath = "./Exemples.txt";

        // using (StreamReader sr = new StreamReader(filepath))

        // sw.WriteLine("Plus rien");

        // using (StreamReader sr = new StreamReader(filepath))

        //     string? line;

        // while ((line = sr.ReadLine()) != null)
        //     Console.WriteLine("ligne : " + line);

        try
        {
            // string text = File.ReadAllText(filepath);
            // Console.WriteLine(text);
            // string src = "Exemples.txt";
            // string dest = "../C#";
            // File.Move(src, dest);
            // File.Create("../Test.txt");
            string[] repertoire = Directory.GetDirectories("./../");
            foreach (string test in repertoire)
            {
                Console.WriteLine(test);
            }
        } catch (Exception e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine("Essaie encore !");
        }
    }
}