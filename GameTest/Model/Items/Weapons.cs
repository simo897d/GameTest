using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace GameTest.Model.Items {
    public class Weapons : InventoryItem {
        public Weapons(int minDamage, int maxDamage, int durability, string itemID, int quantity) : base (itemID, quantity) {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            Durability = durability;

        }

        private int _minDamage;
        private int _maxDamage;
        private int _durability;

        public int MaxDamage {
            get {
                return _maxDamage;
            }
            set {
                _maxDamage = value;
            }
        }
        public int MinDamage {
            get {
                return _minDamage;
            }
            set {
                _minDamage = value;
            }
        }

        public int Durability { get { return _durability; } set { _durability = value; } }

        public bool WeaponDestroyed { get { return Durability <= 0; } }
    }
}
