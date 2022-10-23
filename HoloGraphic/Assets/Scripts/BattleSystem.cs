using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSystem : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void performPlayerMove(Enemy enemy, Card card)
    {
        bool isDead = enemy.takeDamage(card);

        if (isDead)
        {
            //Update UI, remove the enemy from the field, return user to first person POV (?), etc.
            Debug.Log("You have defeated the enemy!");
        }
        else
        {
            enemy.Attack();
        }
    }

    public void endTurn()
    {
        Debug.Log("Ending turn.");
    }
}
