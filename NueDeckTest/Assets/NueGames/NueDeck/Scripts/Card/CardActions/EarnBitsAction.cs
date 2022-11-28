using NueGames.NueDeck.Scripts.Enums;
using NueGames.NueDeck.Scripts.Managers;
using NueGames.NueDeck.Scripts.Card;
using NueGames.NueDeck.Scripts.Data.Collection;
using NueGames.NueDeck.Scripts.Data.Containers;
using NueGames.NueDeck.Scripts.NueExtentions;
using NueGames.NueDeck.Scripts.UI;
using NueGames.NueDeck.Scripts.UI.Reward;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace NueGames.NueDeck.Scripts.Card.CardActions //NueGames.NueDeck.Scripts.UI.Reward
{
    public class EarnBitsAction : CardActionBase
    {
        public UIManager UIManager => UIManager.Instance;
        //public CombatCanvas CombatCanvas => CombatCanvas.Instance;

        public override CardActionType ActionType => CardActionType.EarnBits;
        public override void DoAction(CardActionParameters actionParameters)
        {
            if (CombatManager != null)
            {
                CombatManager.IncreaseBits(Mathf.RoundToInt(actionParameters.Value));
                UIManager.CombatCanvas.SetBitText(GameManager.PersistentGameplayData.CurrentGold);
                //UIManager.InformationCanvas.SetGoldText(GameManager.PersistentGameplayData.CurrentGold);
            }
            else
                Debug.LogError("There is no CombatManager");

            //The fx is applied to SelfCharacter, but we made the character invisible for a first-person experience.
            //Instead replace with fx to the BIT counter. Need a reference to the UI
            if (FxManager != null)
                //Debug.Log(UIManager.CombatCanvas.BitsTextTextField);
                //Debug.Log(UIManager.CombatCanvas.BitsUI.transform);
                //Debug.Log(actionParameters.SelfCharacter.transform);

                //FxManager.PlayFx(actionParameters.SelfCharacter.transform, FxType.Buff);
                FxManager.PlayFx(actionParameters.BitsUI.transform, FxType.Buff);
                //FxManager.PlayFx(UIManager.CombatCanvas.BitsUI.transform, FxType.Attack);
                

            if (AudioManager != null)
                AudioManager.PlayOneShot(actionParameters.CardData.AudioType);
        }
    }
}
