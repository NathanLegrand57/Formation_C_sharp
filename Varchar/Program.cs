using System.Text;

class Program
{
    public static void Main(string[] args)
    {
        /* string a = "Salut à tous, c'est La salle ! ";
        string b =string.Concat(a, "Aller le foot !");

        string[] array = {"Salut","à","tous","c'est","La","salle","!"};

        String s = string.Join(" ",array);

        Console.WriteLine(s);
        Console.WriteLine(b .Replace('a', 'o').ToUpper()); */

        StringBuilder sb = new StringBuilder("Voici la");
            sb.AppendLine();
            sb.Append("suite !");

            Console.WriteLine(sb);
            Thread.Sleep(2000);
            sb.Clear();
    }
}