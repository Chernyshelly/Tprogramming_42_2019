﻿using System;

namespace RPG_autoBattler
{
    public class NinjaPierce : ISpell, IActiveSpell
    {
        public string Name { get; set; }

        public int Lvl { get; set; }

        public float Damage { get; set; }

        public bool IsRanged { get; set; }

        public void Cast(Char caster, Char victim)
        {
            victim.CurHP -= caster.Agility + Damage;
            Logger.TakeDamageM(victim, caster.Agility + Damage);
        }
    }
}
