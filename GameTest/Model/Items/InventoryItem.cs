using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace GameTest.Model.Items {
    public class InventoryItem : INotifyPropertyChanged{

        private string _itemID;
        private int _quantity;

        public string ItemID { get { return _itemID; } set { _itemID = value; } }
        public int Quantity { get { return _quantity; } set { _quantity = value; } }
        public InventoryItem(string itemID, int quantity) {
            ItemID = itemID;
            Quantity = quantity;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
