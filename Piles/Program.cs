using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        Stack<int> values = new Stack<int>();

        values.Push(20);
        values.Push(78);
        values.Push(41);

        values.Clear();

        foreach (var item in values)
        {
            Console.WriteLine(item);
        }

        if (values.Contains(78))
        {
            Console.WriteLine("oui !!!");
        }

        Console.WriteLine(values.Count);
    }
}