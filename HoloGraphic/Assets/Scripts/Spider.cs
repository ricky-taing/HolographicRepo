using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spider : Enemy
{
    public Player player;

    //small attack
    public void Bite(Player player) //Or card??
    {
        //How to apply this number y amount of times?
        int randomNum = Random.Range(1, 5);
        for(int i = randomNum; i > 0; i--)
        {
            player.health -= 10;
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
        health += (attack + 10); // This is the base damage Siphon does, for now + Attack stat modifier
         return attack + 10;
    }
}
