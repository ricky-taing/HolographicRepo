using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public new string name;
    public string description;

    public Sprite artwork;

    //This is a modifier to actual attacks?
    //Do diff enemies have diff attack stats?
    public int attack;
    public int defense;
    //MaxHP, curHP?
    public int health;
    private ArrayList Moves;

    //Make abstract? That way we call this and it calls random move from child?
    //public int Attack()
    //{
    //    Debug.Log("Attack!");
    //    return attack;
    //}

    //Game Dev Experiments Tutorial Youtube
    public bool takeDamage(Card card) //Move move, Player player
    {
        //Or can call card.specialAttack, except that enemy moves are random. What is Moves in the tutorial? A list?
        health -= card.Attack();

        if (health <= 0)
        {
            health = 0;
            return true;
        }
        return false;
    }

    //Try use 1 move first before adding more
    //public Move getRandomMove()
    //{
    //    int r = Random.Range(0, Moves.Count);
    //    return Moves[r];
    //}

   //public void getRandomMove()
    //{
     //   int r = Random.Range(0, Moves.Count);
      //  return Moves[r];
    //}
}
