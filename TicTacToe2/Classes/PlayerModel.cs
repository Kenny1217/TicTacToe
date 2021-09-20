using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe2
{
    /*Kenneth Morris
     * Cis 3309 Tic Tac Toe
     *
     */



    class PlayerModel
    {
        private string hiddenName;
        private char hiddenIcon;


        public PlayerModel(string name, char icon)
        {
            hiddenName = name; // Players Name
            hiddenIcon = icon; // Players Symbole
        }

        public char Icon
        {
            get { return hiddenIcon; } // Return X Or O
        } 

        public string Name
        {
            get { return hiddenName; } // Return Name Of Player
        } 
    }
}
