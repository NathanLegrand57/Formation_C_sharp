using System.Collections.Generic;
using System;

public class PokemonComparerByLevel : IComparer<Pokemon>
{
    public int Compare(Pokemon a, Pokemon b)
    {
        /* Façon de penser :
        Si a > b  : -1
        Si a < b  : 1
        Si a == b : 0 */

        if (a.Level > b.Level)
            return -1;

        else if (a.Level < b.Level)
            return 1;
        return 0;
    }
}

public class PokemonComparerByPV : IComparer<Pokemon>
{
    public int Compare(Pokemon a, Pokemon b)
    {
        if (a.PV > b.PV)
            return -1;

        else if (a.PV < b.PV)
            return 1;
        return 0;
    }
}