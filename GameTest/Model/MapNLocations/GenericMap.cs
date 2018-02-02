using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace GameTest.Model.MapNLocations {
    public class GenericMap : INotifyPropertyChanged{

        private char[,] _genericMapBoard;

        public event PropertyChangedEventHandler PropertyChanged;

        public char[,] GenericMapBoard { get { return _genericMapBoard; } set { _genericMapBoard = value; } }
        public GenericMap(char[,] genericMapBoard) {
            GenericMapBoard = genericMapBoard;
        }
    }
}
