using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public string name;
    public int maxHealth;
    public int curHealth;
    public Card[] hand;

    void Start()
    {
        hand = new Card[5];

    }

    public bool takeDamage(Enemy enemy)
    {
        curHealth -= enemy.Attack();

        if (curHealth <= 0)
        {
            curHealth = 0;
            return true;
        }
        return false;
    }
}
