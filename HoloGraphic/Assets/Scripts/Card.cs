using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject
{
    public new string name;
    public string description;

    public Sprite artwork;

    public int memoryCost;
    public int attack;
    public int defense;
    public int maxHealth;
    public int curHealth;

    //I don't think enemy should be attached to a card...
    //public Enemy enemy;

    public string getName()
    {
        return name;
    }
    public void setName(string newName)
    {
        name = newName;
    }

    public int getMemory()
    {
        return memoryCost;
    }
    public void setMemory(int gigabytes)
    {
        memoryCost = gigabytes;
    }

    public int getAttack()
    {
        return attack;
    }
    public void setAttack(int atkValue)
    {
        attack = atkValue;
    }

    public int getHealth()
    {
        return curHealth;
    }
    public void setHealth(int hpValue)
    {
        curHealth = hpValue;
    }

    public void Print()
    {
        Debug.Log(name + ": " + description);
    }

    public int Attack()
    {
        Debug.Log("Attack!");
        return attack;
        //enemy.health -= attack;
    }


    
}
