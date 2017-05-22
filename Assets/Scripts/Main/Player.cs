using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float health, stamina;
    [SerializeField]
    public Armour[] armourSlots = new Armour[5];
    [SerializeField]
    public Item[] inv = new Item[24];

    public int playerDef, playerAtt;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void addArmour(Armour newArmour)
    {

    }

    //TODO - need to put the armour pieces somewhere
    public void removeArmour(int slot)
    {
        if(armourSlots[slot] != null)
        {
            armourSlots[slot] = null;
        }
    }

    public void addItem()
    {

    }

    public void removeItem(int slot)
    {

    }

    public void swapItems(int firstSlot, int secSlot)
    {
        if(inv[firstSlot] != null)
        {
            Item first = inv[firstSlot];
            Item second = inv[secSlot];

            inv[firstSlot] = second;
            inv[secSlot] = first; 
        }
    }

    /**
    *
    **/
    public void calculateDefense()
    {
        for(int i = 0; i < 5; i++)
        {
            if (armourSlots[i] != null)
            {
                playerDef += armourSlots[i].defense;
            }
            else
            {
                playerDef += 0;
            }
        }
    }





    public string Status()
    {
        string s = "";
        s = s + "Health : " + health + "\n";
        s = s + "Stamina : " + stamina + "\n";
        s = s + "Attack : " + playerAtt + "\n";
        s = s + "Defense : " + playerDef + "\n";
        return s;
    }
}
