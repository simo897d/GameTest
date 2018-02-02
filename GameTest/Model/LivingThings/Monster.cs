using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest.Model {
    public class Monster : LivingCreatures {
        public Monster(int minDamage, int maxDamage, string creatureName, int currentHitPoints, int maxHitPoints) : base(currentHitPoints, maxHitPoints, creatureName) {

        }

        public static Monster Slime() {
            Monster Slime = new Monster(5, 10, "Slime", 5, 5);

            return Slime;
        }
    }
}
