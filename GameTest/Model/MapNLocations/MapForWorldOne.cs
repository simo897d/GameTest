using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest.Model.MapNLocations {
    public class MapForWorldOne : GenericMap{
        public static char[,] WorldOne = new char[10, 10] {
                {'X','X','X','X','X','X','X','X','X','X'},
                {'X','X','X','X','X','X','X','X','X','X'},
                {'X','X','X','X','X','X','X','X','X','X'},
                {'X','X','X','X','X','X','X','X','X','X'},
                {'X','X','X','X','X','X','X','X','X','X'},
                {'X','X','X','X','X','X','X','X','X','X'},
                {'X','X','X','X','X','X','X','X','X','X'},
                {'X','X','X','X','X','X','X','X','X','X'},
                {'X','X','X','X','X','X','X','X','X','X'},
                {'X','X','X','X','X','X','X','X','X','X'},
            }; 

        public MapForWorldOne(char[,] genericMapBoard) : base(genericMapBoard){

        }
        public static string bindString;
        public static string BindingStartingZone() {
            string result = "";
            for (int gameBoardHeight = 0; gameBoardHeight <= 9; gameBoardHeight++) {
                for (int gameBoardLength = 0; gameBoardLength <= 9; gameBoardLength++) {
                    result = result + WorldOne[gameBoardHeight, gameBoardLength];
                }
                result = result + "\n";
            }
            bindString = result;
            return result;
        }
        public static MapForWorldOne StartingZone() {
            

            MapForWorldOne map = new MapForWorldOne(WorldOne);
            return map;
        }
    }
}
