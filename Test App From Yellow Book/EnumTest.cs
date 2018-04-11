using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Test_App_From_Yellow_Book
{
    class EnumTest
    {
        public enum SeaState {EmptySea, Attacked, Battleship, Cruiser, Submarine, RowingBoat};
        public static SeaState mySeaState = new SeaState();


        public EnumTest()
        {

        }

        public static void SetSeaStateCruiser()
        {
            mySeaState = SeaState.Cruiser;
            MessageBox.Show(mySeaState.ToString());
        }

        public static void SetSeaEmptySea()
        {
            mySeaState = SeaState.EmptySea;
            MessageBox.Show(mySeaState.ToString());
        }
    }
}
