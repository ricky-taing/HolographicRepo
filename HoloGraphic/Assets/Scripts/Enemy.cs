using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public new string name;
    public string description;

    public Sprite artwork;

    public int attack;
    public int defense;
    public int health;
    public string specialAttack;
    public void Attack()
    {
        Debug.Log("Attack!");
    }

    //public void specialAttack()
    //{
    //    Debug.Log("Launching Special Attack!");
    //}
}
