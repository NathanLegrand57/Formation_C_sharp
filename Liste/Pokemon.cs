public class Pokemon
{
    public string Name { get; private set; }
    public int Level { get; private set; }
    public String Attack { get; private set; }
    public int PV { get; private set; }

    public Pokemon(string name, int level, String attack, int pv) => (Name, Level, Attack, PV) = (name, level, attack, pv);



    public override String ToString()
    {
        return "[ Nom : " + Name + "] ( Nivau : " + Level + " / Attaque : " + Attack + " / PV : " + PV + " )";
    }
}