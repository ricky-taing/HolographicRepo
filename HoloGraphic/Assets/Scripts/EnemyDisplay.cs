using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EnemyDisplay : MonoBehaviour
{
    public Enemy enemy;

    public TextMeshProUGUI nameText;
    //public TextMeshProUGUI descriptionText;
    //public Image artworkImage;
    //public TextMeshProUGUI memoryText;
    //public TextMeshProUGUI attackText;
    //public TextMeshProUGUI defenseText;
    public TextMeshProUGUI healthText;

    // Start is called before the first frame update
    void Start()
    {
        
        nameText.text = enemy.name;
        healthText.text = enemy.curHealth.ToString();
    }
}
