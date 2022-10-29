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
}
