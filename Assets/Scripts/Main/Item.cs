using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    string name, description;
    Lib.Rarity rarity;

    public Item(string _name, string _description, Lib.Rarity _rarity)
    {
        name = _name;
        description = _description;
        rarity = _rarity;
    }
}
