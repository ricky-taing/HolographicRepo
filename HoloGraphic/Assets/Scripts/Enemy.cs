using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public new string name;
    public string description;

    public Sprite artwork;

    public int attack; //This is a modifier to actual attacks?
    public int defense;
    public int health;
    public int Attack()
    {
        Debug.Log("Attack!");
        return attack;
    }

    public bool takeDamage(Card card) //Move move, Player player
    {
        health -= card.Attack();

        if (health <= 0)
        {
            health = 0;
            //return true;
        }
        return false;
    }

    //public void specialAttack()
    //{
    //    Debug.Log("Launching Special Attack!");
    //}
}
