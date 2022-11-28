﻿using NueGames.NueDeck.Scripts.Enums;
using NueGames.NueDeck.Scripts.Managers;
using TMPro;
using UnityEngine;

namespace NueGames.NueDeck.Scripts.UI
{
    public class CombatCanvas : CanvasBase
    {
        public static CombatCanvas Instance { get; private set; }

        [Header("Texts")]
        [SerializeField] private TextMeshProUGUI drawPileTextField;
        [SerializeField] private TextMeshProUGUI discardPileTextField;
        [SerializeField] private TextMeshProUGUI exhaustPileTextField;
        [SerializeField] private TextMeshProUGUI manaTextTextField;
        [SerializeField] private TextMeshProUGUI bitsTextTextField;
        [SerializeField] private TextMeshProUGUI healthTextField;

        [Header("Panels")]
        [SerializeField] private GameObject combatWinPanel;
        [SerializeField] private GameObject combatLosePanel;

        [Header("Player UI")]
        [SerializeField] private GameObject hpUI;
        [SerializeField] private GameObject ramUI;
        [SerializeField] private GameObject bitsUI;

        public TextMeshProUGUI DrawPileTextField => drawPileTextField;
        public TextMeshProUGUI DiscardPileTextField => discardPileTextField;
        public TextMeshProUGUI ManaTextTextField => manaTextTextField;
        public TextMeshProUGUI BitsTextTextField => bitsTextTextField;
        public GameObject CombatWinPanel => combatWinPanel;
        public GameObject CombatLosePanel => combatLosePanel;
        public TextMeshProUGUI HealthTextField => healthTextField;
        public TextMeshProUGUI ExhaustPileTextField => exhaustPileTextField;

        public GameObject BitsUI => bitsUI;

        #region Setup
        private void Awake()
        {
            CombatWinPanel.SetActive(false);
            CombatLosePanel.SetActive(false);
        }
        #endregion

        #region Public Methods
        public void SetPileTexts()
        {
            DrawPileTextField.text = $"{CollectionManager.DrawPile.Count.ToString()}";
            DiscardPileTextField.text = $"{CollectionManager.DiscardPile.Count.ToString()}";
            ExhaustPileTextField.text =  $"{CollectionManager.ExhaustPile.Count.ToString()}";
            ManaTextTextField.text = $"{GameManager.PersistentGameplayData.CurrentMana.ToString()}/{GameManager.PersistentGameplayData.MaxMana}";
        }

        public void SetBitText(int value) => bitsTextTextField.text = $"{value}";

        public void SetHealthText(int currentHealth, int maxHealth) => HealthTextField.text = $"{currentHealth}/{maxHealth}";

        public override void ResetCanvas()
        {
            base.ResetCanvas();
            CombatWinPanel.SetActive(false);
            CombatLosePanel.SetActive(false);
        }

        public void EndTurn()
        {
            if (CombatManager.CurrentCombatStateType == CombatStateType.AllyTurn)
                CombatManager.EndTurn();
        }
        #endregion
    }
}