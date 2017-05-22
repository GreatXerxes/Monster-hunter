using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armour
{


    public string name, description;
    public Lib.TYPE type;
    public Lib.Rarity rarity;
    public int defense;

	public Armour(string _name, string _description, int _defense, Lib.TYPE _type, Lib.Rarity _rarity)
    {
        name = _name;
        description = _description;
        defense = _defense;
        type = _type;
        rarity = _rarity;
    }
}
