﻿using System;

namespace RPG_autoBattler
{
    public class HammerStrike : ISpell, IActiveSpell
    {
        string ISpell.Name { get; set; }

        int ISpell.Lvl { get; set; }

        public int StunDuration { get; set; }

        bool IActiveSpell.IsRanged { get; set; }

        void IActiveSpell.Cast(Char caster, Char victim)
        {
            Logger.StunM(victim, StunDuration);
            victim.TakeDamage(caster, caster.Agility);
            victim.StunTimer += StunDuration;
        }
    }
}
