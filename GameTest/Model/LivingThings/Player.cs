﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using GameTest.Model.Items;
using System.Collections.ObjectModel;

namespace GameTest.Model {
    public class Player : LivingCreatures {

        private Weapons _weapon;
        public Weapons CurrentWeapon { get { return _weapon; } set { _weapon = value; } }
        public ObservableCollection<InventoryItem> ListOfInventory { get; set; }

        public Player(int currentHitPoints, int maxHitPoints, string creatureName, Weapons equippedWep) : base(currentHitPoints, maxHitPoints, creatureName) {
            ListOfInventory = new ObservableCollection<InventoryItem>();
            CurrentWeapon = equippedWep;
        }
        public static Player DefaultPlayer() {
            Player defPlayer = new Player(100, 100, "PlayerName", Swords.WoodenSword()); //Replace playername with string to set Playername

            defPlayer.ListOfInventory.Add(Swords.WoodenSword());
            return defPlayer;
        }


        public void TakeDamage() {
            //Lose HP
        }
        public int DoDamageRoll() {
            int min;
            int max;

            min = CurrentWeapon.MinDamage;
            max = CurrentWeapon.MaxDamage;

            Random rnd = new Random();
            int dice = rnd.Next(min, max);
            return dice;
        }
        public void StartWep() {
            CurrentWeapon = Swords.WoodenSword();
        }
    }
}
