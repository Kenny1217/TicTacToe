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

    class BoardModel
    {
        String [,] boardarray = new String[3, 3];

        public bool hasPlayerWon(String currentPlayer) // Checks For Winner
        {
            //Check Rows
            if (boardarray[0, 0] == currentPlayer && boardarray[0, 1] == currentPlayer && boardarray[0, 2] == currentPlayer) { return true; }
            if (boardarray[1, 0] == currentPlayer && boardarray[1, 1] == currentPlayer && boardarray[1, 2] == currentPlayer) { return true; }
            if (boardarray[2, 0] == currentPlayer && boardarray[2, 1] == currentPlayer && boardarray[2, 2] == currentPlayer) { return true; }
            // Check Columns
            if (boardarray[0, 0] == currentPlayer && boardarray[1, 0] == currentPlayer && boardarray[2, 0] == currentPlayer) { return true; }
            if (boardarray[0, 1] == currentPlayer && boardarray[1, 1] == currentPlayer && boardarray[2, 1] == currentPlayer) { return true; }
            if (boardarray[0, 2] == currentPlayer && boardarray[1, 2] == currentPlayer && boardarray[2, 2] == currentPlayer) { return true; }
            // Check Diangle
            if (boardarray[0, 0] == currentPlayer && boardarray[1, 1] == currentPlayer && boardarray[2, 2] == currentPlayer) { return true; }
            if (boardarray[0, 2] == currentPlayer && boardarray[1, 1] == currentPlayer && boardarray[2, 0] == currentPlayer) { return true; }
            return false;
        }

        public void recordTurn(String currentPlayer, int cellID) //Stores Who Click Cell In Array 
        {
            if (cellID == 192) boardarray[0, 0] = currentPlayer; //[0,0]
            if (cellID == 193) boardarray[0, 1] = currentPlayer; //[0,1]
            if (cellID == 194) boardarray[0, 2] = currentPlayer; //[0,2]
            if (cellID == 195) boardarray[1, 0] = currentPlayer; //[1,0]
            if (cellID == 196) boardarray[1, 1] = currentPlayer; //[1,1]
            if (cellID == 197) boardarray[1, 2] = currentPlayer; //[1,2]
            if (cellID == 198) boardarray[2, 0] = currentPlayer; //[2,0]
            if (cellID == 199) boardarray[2, 1] = currentPlayer; //[2,1]
            if (cellID == 200) boardarray[2, 2] = currentPlayer; //[2,2]
        }

        public bool IsDraw(int turnCount) // Checks For Draw
        {
            if (turnCount >= 9) // Draw Is If 9 Moves Without Winner
            {
                return true;   // There Is A Draw
            }
         return false; // No Draw
        }
    }
}
