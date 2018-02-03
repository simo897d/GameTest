using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameTest.Model;
using GameTest.Model.MapNLocations;
using GameTest.Model.Items;
using System.Collections.ObjectModel;

namespace GameTest.ViewModelNS {
    public class ViewModel {
        public ViewModel() {
            CurrentZone();
        }
        private Player _player;
        private Monster _monster;
        private MapForWorldOne _mapForWorldOne;
        private ObservableCollection<InventoryItem> _listOfInventory;
        private string _mapBindingStart;
        private GenericMap _currentZone;

        public GenericMap CurrentZoneProp { get { return _currentZone; } set { _currentZone = value; } }

        public Player CurrentPlayer {
            get {
                if (_player == null) {
                    _player = Player.DefaultPlayer();
                    return _player;
                } else { return _player; }
            }
        }
        public GenericMap CurrentZone() {
            if(CurrentZoneProp == null) {
                StartingZone();
            } else { return CurrentZoneProp; }
            return CurrentZoneProp;
        }
        public string MapBindingStart { get { return _mapBindingStart; } set { _mapBindingStart = value; } }
        public MapForWorldOne StartingZone() {
            _mapForWorldOne = MapForWorldOne.StartingZone();
            MapForWorldOne.BindingMapString();
            MapBindingStart = MapForWorldOne.BindingMapString();
            return _mapForWorldOne;
        }
        public ObservableCollection<InventoryItem> ListOfIventory {
            get {
                _listOfInventory = CurrentPlayer.ListOfInventory;
                return _listOfInventory;
            }
        }

        public Monster SetMonster { get { return _monster; } set { _monster = value; } } //Redundant?
        public Monster MonsterEncounter() {
            return _monster;
        }
        public string DidDamage() {
            string output;
            if (MonsterEncounter() == null) {
                output = "You're not in combat \n";
            } else {
                output = "You did " + CurrentPlayer.DoDamageRoll().ToString() + " damage to" + MonsterEncounter().CreatureName + "\n";
            }
            return output;
        }
        public void MovePlayer() {

        }


    }
}
