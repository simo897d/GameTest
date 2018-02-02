using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace GameTest.Model
{
    public class LivingCreatures : INotifyPropertyChanged
    {
        private int _currentHitPoints;
        private string _creatureName;

        public string CreatureName { get { return _creatureName; } set { _creatureName = value; } }
        public int CurrentHitPoints { get { return _currentHitPoints; }
            set { _currentHitPoints = value;
                OnPropertyChanged("CurrentHitPoints");
            }
        }

        public int MaxHitPoints { get; set; }
        public bool IsDead { get { return CurrentHitPoints <= 0; } }

        public LivingCreatures(int currentHitPoints, int maxHitPoints, string creatureName) {
            CurrentHitPoints = currentHitPoints;
            MaxHitPoints = maxHitPoints;
            CreatureName = creatureName;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name) {
            if(PropertyChanged != null) {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
