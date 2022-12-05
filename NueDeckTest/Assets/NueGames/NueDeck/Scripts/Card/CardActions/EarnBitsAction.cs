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

            if (FxManager != null)
                FxManager.PlayFx(actionParameters.SelfCharacter.transform, FxType.Stun);

            if (AudioManager != null)
                AudioManager.PlayOneShot(actionParameters.CardData.AudioType);
        }
    }
}
