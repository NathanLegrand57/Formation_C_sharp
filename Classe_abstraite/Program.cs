using System;

abstract class Animaux
{
    public void Terre()
    {
        Console.WriteLine("Je suis sur la Terre");
    }
    public abstract void Bruit();
}
class Chat : Animaux
{
    public override void Bruit() => Console.WriteLine("Miaouw");
}

class Chien : Animaux
{
    public override void Bruit() => Console.WriteLine("Ouaf");
}

class program
{
    public static void Main(string []args)
    {
        Chat c = new Chat();
        Chien ch = new Chien();

        c.Bruit();
        ch.Bruit();

        c.Terre();
        ch.Terre();
    }
}

