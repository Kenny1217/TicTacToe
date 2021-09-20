using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe2
{

    /*Kenneth Morris
     * Cis 3309 Tic Tac Toe
     *
     */
    public partial class frmTicTacToe : Form
    {

        private List<PlayerModel> playersList = new List<PlayerModel>(2);
        private PlayerModel currentPlayer;
        private BoardModel internalBoardRep = new BoardModel();
        private Button[,] newButton = new Button[5, 5];
        private int turnCount = 0;


        public frmTicTacToe()
        {
            InitializeComponent();
        }
        private bool validateName(string name)
        {
            if(name == "" || name.Any(char.IsDigit)) // CHeck If Blank Or Contains Number
            {
                return false; // Name Is Blank Or Contains A Number
            }
            return true; // Vaild Name
        }
        private bool nameMatch()
        {
            if (txtPlayer1Name.Text != txtPlayer2Name.Text) // Check If Names Match
            {
                return true; // Names Don't Match
            }
            return false; // Names Match
        }
        private void retryNames()
        {
            MessageBox.Show("Sorry names can't be the same", "Entry Error"); // Message Box That Names Can't Match
            txtPlayer1Name.Text = ""; // Clears Textbox
            txtPlayer2Name.Text = ""; // Clears Textbox
            lblPlayer2Name.Visible = false; // Make Label Hidden
            txtPlayer2Name.Visible = false; // Make Textbox Hidden
            btnPlayer2Name.Visible = false; // Make Button Hidden
            txtPlayer1Name.ReadOnly = false; // Make Textbox Editable
            btnPlayer1Name.Visible = true; // Make Button Visible
        }

        private void createBoard()
        {
            pnlBoard.Visible = true;
            Size size = new Size(75, 75);
            Point loc = new Point(0, 0);
            int padding = 25;
            // Button [,] btnSpace = new Button [2,2];
            int topMargin = 40;
            for (int row = 0; row <= 2; row++)
            {
                loc.Y = topMargin + row * (size.Height + padding);
                int extraLeftPadding = 80;
                for (int col = 0; col <= 2; col++)
                {
                    Button newButton = new Button();
                    newButton.Location = new Point(extraLeftPadding + col * (size.Width + padding), loc.Y);
                    newButton.Size = size;
                    newButton.Font = new Font("Arial", 48, FontStyle.Bold);
                    newButton.Text = "";
                    newButton.Enabled = true;
                    newButton.Name = "btn" + row + col;
                    newButton.Click += new EventHandler(Button_Click);
                    pnlBoard.Controls.Add(newButton);
                }
            }
        }
        private void alternateTurn() // Changes Current Player
        {
            if (currentPlayer == playersList[0]) // Check Who Is Current Player
            {
                currentPlayer = playersList[1]; // Switch Current Player
            }
            else
            {
                currentPlayer = playersList[0]; // Switch Current Player
            }
            txtCurrentPlayer.Text = currentPlayer.Name; // Show Current Player In Textbox
        }

        private void Button_Click(object sender, EventArgs e)
        {
           int rowID = Convert.ToInt16(((Button)sender).Name[3]);
           int colID = Convert.ToInt16(((Button)sender).Name[4]);
           int cellID = rowID * 3 + colID;
           internalBoardRep.recordTurn(currentPlayer.Name, cellID);
           string thisToken = (currentPlayer.Icon).ToString();
           ((Button)sender).Text = thisToken;
           if (thisToken == "X") ((Button)sender).ForeColor = Color.Orange;
            ((Button)sender).Enabled = false;
            if (internalBoardRep.hasPlayerWon(currentPlayer.Name)) // Check For Win
            {
                MessageBox.Show(currentPlayer.Name + " Has Won The Game!", currentPlayer.Icon + " Is The Winner!");
                this.Close(); // Close Program
            }
            else
            {
                turnCount++; // Add To Turn Count
                if (internalBoardRep.IsDraw(turnCount)) // Check For Draw
                {
                    MessageBox.Show("Game over.  We have a draw.", "Draw!"); // Draw Message
                    this.Close(); // Close Program
                }
                else {
                    alternateTurn(); // Change Current Player
                }
            }
        }

        private void frmTicTacToe_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Are you ready to play some Tic Tac Toe", "It Runs"); // Program Works
        }

        private void btnPlayer1Ok_Click(object sender, EventArgs e)
        {
            if (validateName(txtPlayer1Name.Text)) // Checks If Valid Name Is Entered
            {
                txtPlayer1Name.ReadOnly = true; // Make Textbox Read Only
                btnPlayer1Name.Visible = false; // Make Button Hidden
                lblPlayer2Name.Visible = true; // Make Label Visible
                txtPlayer2Name.Visible = true; // Make Textbox Visible
                btnPlayer2Name.Visible = true; // Make Button Visible
                txtPlayer2Name.Focus(); // Set Focus On Textbox
            }
            else
            {
                // Player 1 Name isn't Valid
                MessageBox.Show("Please enter a valid name!", "Entry Error"); // Player Didn't Enter Vaild Name
                txtPlayer1Name.Text = ""; // Clears Textbox
                txtPlayer1Name.Focus(); // Set Focus On Textbox
            }
        }

        private void btnPlayer2Name_Click(object sender, EventArgs e)
        {
            if (validateName(txtPlayer2Name.Text)) // Checks If Valid Name Is Entered
            {
                if (nameMatch()) // Check If Names Match
                {
                    txtPlayer2Name.ReadOnly = true; // Set Textbox To Read only
                    btnPlayer2Name.Visible = false; // Make Button Disappear
                    btnPlayGame.Visible = true; // Make Button Visible
                }
                else
                {
                    retryNames(); // Reset So User Can Enter Names Again
                }
            }
            else
            {
                // Player 2 Name isn't Valid
                MessageBox.Show("Please enter a valid name!", "Entry Error"); // Player Didn't Enter Vaild Name
                txtPlayer2Name.Text = ""; // Clears Textbox
                txtPlayer2Name.Focus(); // Set Focus On Textbox
            }
        }

        private void btnPlayGame_Click(object sender, EventArgs e)
        {
            btnPlayGame.Visible = false;
            string player1Name = txtPlayer1Name.Text; // Store player 1 name
            string player2Name = txtPlayer2Name.Text; // Store player 2 name
            if ((player1Name.Length > 0 && player2Name.Length > 0)
                 && (player1Name != player2Name)) // Double Check If Names Are Valid
            {
                PlayerModel p;
                p = new PlayerModel(player1Name, 'X'); // Create New PlayerModel Object
                playersList.Add(p); // Store Player Into A List
                p = new PlayerModel(player2Name, 'O'); // Create New PlayerModel Object
                playersList.Add(p); // Store Player Into A List
                currentPlayer = playersList[0]; // Set Current Player
                createBoard(); // Create Board
                lblCurrentPlayer.Visible = true; // Set Label Visable
                txtCurrentPlayer.Visible = true; // Set Textbox Visable
                txtCurrentPlayer.Text = currentPlayer.Name; // Set Text In Textbox
            }
            else
            {
                retryNames(); // Make User Enter Names Again 
            }
        }
    }
}