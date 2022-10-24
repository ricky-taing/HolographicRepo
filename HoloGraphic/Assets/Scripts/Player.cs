using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health;
    public Card[] hand;

    void Start()
    {
        hand = new Card[5];

    }
}
