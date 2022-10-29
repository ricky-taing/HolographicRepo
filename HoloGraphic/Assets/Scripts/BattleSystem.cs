using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum BattleState { START, PLAYERTURN, ENEMYTURN, WON, LOST }
public class BattleSystem : MonoBehaviour
{
    //Game Dev Experiment Tutorial on Youtube
    //Scriptable obj for enemies? But then no inheritance right?

    public Player playerPrefab;
    public Enemy enemyPrefab;

    public Transform playerPos; //Instead of "platforms" where player and enemy would stand, pass in the draggable zones for these var?
    public Transform enemyPos;

    public Text dialogueText;

    public BattleHUD playerHUD;
    public BattleHUD enemyHUD;

    public BattleState state;

    void Start()
    {
        state = BattleState.START;
        StartCoroutine(SetupBattle());
    }

    IEnumerator SetupBattle()
    {
        Player player = Instantiate(playerPrefab, playerPos);

        Enemy enemy = Instantiate(enemyPrefab, enemyPos);
        //dialogueText.text = enemy.name;

        //playerHUD.SetHUD(player);
        //enemyHUD.SetHUD(enemy);

        yield return new WaitForSeconds(2f);

        state = BattleState.PLAYERTURN;
        PlayerTurn();
    }

    //Have to implement our cards and dragging into attack
    //How to reference a card from Player hand to attack?
    IEnumerator PlayerAttack()
    {
        bool isDead = false;
        //Damage the enemy
        Enemy enemy = enemyPrefab;
        //isDead = enemy.takeDamage(card);
        yield return new WaitForSeconds(2f);

        if (isDead)
        {
            //End the battle
            //Update UI, remove the enemy from the field, return user to first person POV (?), etc.
            Debug.Log("You have defeated the enemy!");
        }
        //else
        //{
        //    Enemy Turn
        //    enemy.Attack();
        //}
    }
    void PlayerTurn()
    {
        dialogueText.text = "Choose an action:";
    }

    //if using buttons
    public void OnAttackButton()
    {
        if (state != BattleState.PLAYERTURN)
        {
            return;
        }
        StartCoroutine(PlayerAttack());
    }

    //1. Turn based system
    //2. call this method
    /*public void performPlayerMove(Enemy enemy, Card card)
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
    }*/

    public void endTurn()
    {
        Debug.Log("Ending turn.");
    }
}
