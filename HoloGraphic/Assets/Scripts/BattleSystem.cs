using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BattleState { START, PLAYERTURN, ENEMYTURN, WON, LOST }
public class BattleSystem : MonoBehaviour
{
    //Game Dev Experiment Tutorial on Youtube
    //Scriptable obj for enemies? But then no inheritance right?

    public Player playerPrefab;
    public Enemy enemyPrefab;

    public Transform playerPos; //Instead of "platforms" where player and enemy would stand, pass in the draggable zones for these var?
    public Transform enemyPos;

    //Unit playerUnit;
    //Unit enemyUnit;

    public BattleState state;
    
    void Start()
    {
        state = BattleState.START;
        SetupBattle();
    }

    void SetupBattle()
    {
        Debug.Log("hi");
        //GameObject playerGO = Instantiate(player, playerPos); //Spawning in units
        Player playerGO = Instantiate(playerPrefab, playerPos);
        //playerGO.GetComponent<Unit>();
        Instantiate(enemyPrefab, enemyPos);
    }

    //1. Turn based system
    //2. call this method
    public void performPlayerMove(Enemy enemy, Card card)
    {
        bool isDead = enemy.takeDamage(card);

        if (isDead)
        {
            //Update UI, remove the enemy from the field, return user to first person POV (?), etc.
            Debug.Log("You have defeated the enemy!");
        }
        //else
        //{
        //    enemy.Attack();
        //}
    }

    //What is IEnumerator?
    /*public void enemyMove(Enemy enemy, Card card)
    {
        state = BattleState.EnemyMove;
        var move = enemy.getRandomMove();
        bool isDead = card.takeDamage(card);

        if (isDead)
        {
            //Update UI, remove the enemy from the field, return user to first person POV (?), etc.
            Debug.Log("You have been defeated!");
        }
        else
        {
            performPlayerMove();
        }
    }*/

    public void endTurn()
    {
        Debug.Log("Ending turn.");
    }
}
