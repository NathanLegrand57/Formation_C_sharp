internal partial class Program
{
    private static void Main(string[] args)
    {
        Pokemon Dracaufeu = new Pokemon("Dracaufeu", 52, "Lance-Flamme", 504);
        Pokemon Ronflex = new Pokemon("Ronflex", 78, "Repos", 1052);
        Pokemon Musteflott = new Pokemon("Mustéflott", 100, "Tsunami", 358);

        List<Pokemon> deck = new List<Pokemon>();
        deck.Add(Dracaufeu);
        deck.Add(Ronflex);
        deck.Add(Musteflott);

        // deck.Remove(Dracaufeu);
        Console.WriteLine($"Nombre de cartes dans le deck : {deck.Count}");
        // Console.WriteLine(deck.IndexOf(Musteflott));
        // Console.WriteLine(deck[0]);
        // deck.Insert(0, Dracaufeu); Insère une carte dans le deck au premier slot (Exemple : Dracaufeu)
        // deck.RemoveAt(0); Supprime la carte au slot 0
        // deck.InsertRange(0, Dracaufeu, Ronflex); Ajoute plsueirus cartes en même temps en partant du slot 0
        try
        {
            deck.Sort(new PokemonComparerByPV());
            deck.Sort(new PokemonComparerByLevel());
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        foreach (var carte in deck)
        {
            Console.WriteLine(carte);
        }
    }
}

