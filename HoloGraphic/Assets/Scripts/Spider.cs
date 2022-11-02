using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spider : Enemy
{
    public Player player;

    //Should we use methods or scriptable obj for moves? Our moves don't have stats like accuracy, energy (for enemies) yet so method I think

    public Spider(int attack, int maxHealth)
    {
        attack = this.attack;
        maxHealth = this.maxHealth;
    }

    //Small attack
    public void Bite(Player player) //Or card??
    {
        int randomNum = Random.Range(1, 5);
        for(int i = randomNum; i > 0; i--)
        {
            player.curHealth -= 10;
        }
        //return 10;
    }

    //Apply "bleed" effect to Player's health
    public void Leech()
    {
        Debug.Log("Gimme your RAM RAAAAAAAH!");

        //player.hp - 2 every turn
        //1. Implement turn based system
        //Someone affect the player hp every turn...
    }

    //Deal damage and heal for some amount
    public int Siphon()
    {
        Debug.Log("Mmm so tasty!");
        curHealth += (attack + 10); // This is the base damage Siphon does, for now + Attack stat modifier
         return attack + 10;
    }
}
