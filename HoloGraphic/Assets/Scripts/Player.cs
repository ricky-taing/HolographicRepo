using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public string name;
    public int maxHealth;
    public int curHealth;

    public List<Card> hand = new List<Card>();
    public List<Card> deck = new List<Card>();

    void Start()
    {
        hand.Capacity = 5;

        Card gratis = new Card();
        gratis.setName("Gratis");
        gratis.setAttack(5);
        gratis.setHealth(100);

        //deck.Add(gratis);

        hand.Add(gratis);
        //hand = new Card[] {gratis};

        //When make 5 cards to add
        /*for (int i = 0; i < 5; i++) {
            hand.Add(deck[i]);
        }*/
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
