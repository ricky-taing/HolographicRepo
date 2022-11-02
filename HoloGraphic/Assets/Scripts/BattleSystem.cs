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
    Player player;
    Enemy enemy;
    //private Card card; // We don't pass in a card, so how do we reference card for enemy to take damage?
    public Card card;

    public Transform playerPos;
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

    //Spawns player, enemies and starts player turn
    IEnumerator SetupBattle()
    {
        player = Instantiate(playerPrefab, playerPos);

        enemy = Instantiate(enemyPrefab, enemyPos);

        Spider spider = new Spider(2, 10);
        List<Enemy> enemyList = new List<Enemy>();
        enemyList.Add(spider);
        //enemyList.Add(Warden);

        foreach (Enemy enemy in enemyList)
        {
            enemyPrefab = enemy;
            //enemyPos = HorizontalLayoutGroup
            Instantiate(enemyPrefab, enemyPos);
        }

        //playerHUD.SetHUD(player);
        //enemyHUD.SetHUD(enemy);

        yield return new WaitForSeconds(2f);

        state = BattleState.PLAYERTURN;
        PlayerTurn();
    }

    //Have to implement our cards and dragging into attack
    IEnumerator PlayerAttack()
    {
        card = player.hand[0];
        //card = player.hand.g
        Debug.Log(card.name);
        bool isDead = false;
        isDead = enemy.takeDamage(card);

        enemyHUD.SetHP(enemy.curHealth);
        dialogueText.text = "The attack is successful";

        Debug.Log("We get to this point in code");

        yield return new WaitForSeconds(2f);

        if (isDead)
        {
            //End the battle
            //Update UI, remove the enemy from the field, return user to first person POV (?), etc.
            Debug.Log("You have defeated the enemy!");
            state = BattleState.WON;
            EndBattle();
        }
        else
        {
            state = BattleState.ENEMYTURN;
            StartCoroutine(EnemyTurn());
        }
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

    void PlayerTurn()
    {
        dialogueText.text = "Choose an action:";
    }

    IEnumerator EnemyTurn()
    {
        dialogueText.text = enemy.name + " attacks!";
        yield return new WaitForSeconds(1f);
        bool isDead = player.takeDamage(enemy); //Change to enemy random attack here
        playerHUD.SetHP(player.curHealth);
        yield return new WaitForSeconds(1f);
        if (isDead)
        {
            state = BattleState.LOST;
            EndBattle();
        }
        else
        {
            state = BattleState.PLAYERTURN;
            PlayerTurn();
        }
    }

    public void endTurn()
    {
        Debug.Log("Ending turn.");
    }

    void EndBattle()
    {
        if (state == BattleState.WON)
        {
            dialogueText.text = "You won the battle!";
        }
        else if (state == BattleState.LOST)
        {
            dialogueText.text = "You were defeated.";
        }
    }
}
