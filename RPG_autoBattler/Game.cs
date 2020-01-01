﻿using System;
using System.Collections.Generic;

namespace RPG_autoBattler
{
    public class Game
    {
        private static List<Spell> palaSpells = new List<Spell>();
        private static List<Spell> ninjaSpells = new List<Spell>();
        private static List<Spell> mageSpells = new List<Spell>();

        public static void Main()
        {
            palaSpells = ReturnFuncs.RetPalSpells();
            ninjaSpells = ReturnFuncs.RetNinjaSpells();
            mageSpells = ReturnFuncs.RetMageSpells();
            List<string> names = ReturnFuncs.RetNames();
            List<string> surnames = ReturnFuncs.RetSurnames();
            List<Char> fighters = new List<Char>();

            // List<string> names;
            // RetNames().CopyTo(names);
            // palSpells.Add(palBaseAttack);
            Console.WriteLine("Welcome to the Battle for Glory Arena. Press any key to start");
            /*Console.ReadKey();
            Console.WriteLine("Choose your class, type 'Paladin', 'Ninja' or 'Mage' here: ");
            string playerClass = Console.ReadLine();
            while ((playerClass != "Paladin") && (playerClass != "Ninja") && (playerClass != "Mage"))
            {
                Console.WriteLine("Error recognizing class, try to write again or copy and paste class name here: ");
                playerClass = Console.ReadLine();
            }*/

            Char winner = TournamentBattle.Tournament(ReturnFuncs.RetFighters(4));
            Console.WriteLine($"{winner.ToString()} won the tournament!");
            Console.ReadKey();
        }
    }
}