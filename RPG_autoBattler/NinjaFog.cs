﻿using System;

namespace RPG_autoBattler
{
    public class NinjaFog : ISpell, IActiveSpell
    {
        string ISpell.Name { get; set; }

        int ISpell.Lvl { get; set; }

        bool IActiveSpell.IsRanged { get; set; }

        public int DodgeChance { get; set; }

        public int Duration { get; set; }

        void IActiveSpell.Cast(Char caster, Char victim)
        {
            FogHide fogHide = new FogHide();
            fogHide.DodgeChance = DodgeChance;
            fogHide.TurnsLeft = Duration;
            caster.Effects.Add(fogHide);
        }
    }
}