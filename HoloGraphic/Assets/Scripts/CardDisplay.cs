using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardDisplay : MonoBehaviour
{
    public Card card;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI descriptionText;
    //public Image artworkImage;
    public TextMeshProUGUI memoryText;
    public TextMeshProUGUI attackText;
    //public TextMeshProUGUI defenseText;
    public TextMeshProUGUI healthText;

    // Start is called before the first frame update
    void Start()
    {
        //card.Print();
        nameText.text = card.name;
        descriptionText.text = card.description;

        //artworkImage.sprite

        memoryText.text = card.memoryCost.ToString();
        attackText.text = card.attack.ToString();
        healthText.text = card.health.ToString();
    }
}
