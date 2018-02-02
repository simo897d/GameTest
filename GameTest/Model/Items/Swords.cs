using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest.Model.Items {
    public class Swords : Weapons{
        public Swords(int minDamage, int maxDamage, int durability, string itemID, int quantity) : base (minDamage, maxDamage, durability, itemID, quantity) {

        }

        public static Swords WoodenSword() {
            Swords WoodenSword = new Swords(1, 3, 10, "Wooden Sword", 1);
            return WoodenSword;
        }
    }
}
