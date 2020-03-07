﻿using System;

namespace RPG_autoBattler
{
    public class Burning : IPassiveSpell
    {
        public float Damage { get; set; }

        public int TurnsLeft { get; set; }

        public void Trigger(TriggerType triggerType, Character attacker, Character victim, float[] specVal)
        {
            if ((triggerType == TriggerType.EndTurn) && (specVal[0] == 0) && (TurnsLeft > 0))
            {
                Console.WriteLine($"{attacker} is on fire! {TurnsLeft - 1} turns left!");
                TurnsLeft--;
                attacker.TakeDamage(victim, Damage);
            }
        }
    }
}
