using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace GameTest.Model.MapNLocations {
    public class GenericMap : INotifyPropertyChanged{

        private static char[,] _genericMapBoard;
        private char _playerPosition;
        public event PropertyChangedEventHandler PropertyChanged;

        public static char[,] GenericMapBoard { get { return _genericMapBoard; } set { _genericMapBoard = value; } }
        public char PlayerPosition { get { return _playerPosition; } set { _playerPosition = value; } }
        public GenericMap(char[,] genericMapBoard, char playerPosition) {
            GenericMapBoard = genericMapBoard;
            PlayerPosition = playerPosition;
        }

        public static string BindingMapString() {
            string result = "";
            string bindString = "";
            for (int gameBoardHeight = 0; gameBoardHeight <= 9; gameBoardHeight++) {
                for (int gameBoardLength = 0; gameBoardLength <= 9; gameBoardLength++) {
                    result = result + "     " + GenericMapBoard[gameBoardHeight, gameBoardLength];
                }
                result = result + "\n";
            }
            bindString = result;
            return result;
        }
    }
}
