using NueGames.NueDeck.Scripts.Enums;
using NueGames.NueDeck.Scripts.Managers;
using UnityEngine;

namespace NueGames.NueDeck.Scripts.EnemyBehaviour.EnemyActions
{
    public class EnemyInfectAction : EnemyActionBase
    {
        public override EnemyActionType ActionType => EnemyActionType.Infect;
        public int maxInfectTurns = 3;
        public override void DoAction(EnemyActionParameters actionParameters)
        {
            var newTarget = actionParameters.TargetCharacter;
            
            if (!newTarget) return;
            if (++GameManager.infectionCounterAlly == maxInfectTurns)  {  GameManager.infectionCounterAlly = 0;   }
            if (!actionParameters.TargetCharacter) return;
            var value = Mathf.RoundToInt(actionParameters.Value);
            CombatManager.infectionTargetAlly = newTarget;
            CombatManager.infectEnemyValue = value;
            actionParameters.TargetCharacter.CharacterStats.Damage(value);
        }
    }
}
