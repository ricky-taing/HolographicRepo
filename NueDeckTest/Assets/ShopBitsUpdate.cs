using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NueGames.NueDeck.Scripts.Managers;
using TMPro;

public class ShopBitsUpdate : MonoBehaviour
{
    public GameManager GameManager => GameManager.Instance;
    [SerializeField] private TextMeshProUGUI bitsRemainingText;
    // Start is called before the first frame update
    void Start()
    {
        bitsRemainingText.text = GameManager.PersistentGameplayData.CurrentGold.ToString();
        Debug.Log(GameManager.PersistentGameplayData.CurrentGold);
    }

    // Update is called once per frame
    void Update()
    {
        bitsRemainingText.text = GameManager.PersistentGameplayData.CurrentGold.ToString();
        Debug.Log(GameManager.PersistentGameplayData.CurrentGold);
    }
}
