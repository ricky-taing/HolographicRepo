using NueGames.NueDeck.Scripts.Enums;
using NueGames.NueDeck.Scripts.Managers;
using UnityEngine;

namespace NueGames.NueDeck.Scripts.Card.CardActions
{
    public class InfectAction : CardActionBase
    {
        public override CardActionType ActionType => CardActionType.Infect;
        public int maxInfectTurns = 3;
        public override void DoAction(CardActionParameters actionParameters)
        {
            if (!actionParameters.TargetCharacter) return;

            var targetCharacter = actionParameters.TargetCharacter;
            var selfCharacter = actionParameters.SelfCharacter;

            if (++GameManager.infectionCounterEnemy == maxInfectTurns) { GameManager.infectionCounterEnemy = 0; }
            var value = Mathf.RoundToInt(actionParameters.Value); //+ selfCharacter.CharacterStats.StatusDict[StatusType.Strength].StatusValue;

            if (AudioManager != null) 
                AudioManager.PlayOneShot(actionParameters.CardData.AudioType);

            targetCharacter.CharacterStats.Damage(Mathf.RoundToInt(value));
            CombatManager.infectionTargetEnemy = targetCharacter;
            CombatManager.infectPlayerValue = value;
        }
    }
}