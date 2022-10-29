using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleHUD : MonoBehaviour
{
    public Text nameText;
    public Text levelText;
    public Slider hpSlider;

    public void SetHUD(Player player, Enemy enemy)
    {
        nameText.text = enemy.name;
        //levelText.text = 
        hpSlider.maxValue = enemy.maxHealth;
        hpSlider.value = enemy.curHealth;
    }

    public void SetHP(int hp)
    {
        hpSlider.value = hp;
    }
}
