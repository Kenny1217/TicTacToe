namespace TicTacToe2
{
    partial class frmTicTacToe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblPlayer1Name = new System.Windows.Forms.Label();
            this.lblPlayer2Name = new System.Windows.Forms.Label();
            this.txtPlayer1Name = new System.Windows.Forms.TextBox();
            this.txtPlayer2Name = new System.Windows.Forms.TextBox();
            this.btnPlayer1Name = new System.Windows.Forms.Button();
            this.btnPlayer2Name = new System.Windows.Forms.Button();
            this.btnPlayGame = new System.Windows.Forms.Button();
            this.pnlBoard = new System.Windows.Forms.Panel();
            this.lblCurrentPlayer = new System.Windows.Forms.Label();
            this.txtCurrentPlayer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblWelcome.Location = new System.Drawing.Point(13, 13);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(235, 25);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome To Tic Tac Toe";
            // 
            // lblPlayer1Name
            // 
            this.lblPlayer1Name.AutoSize = true;
            this.lblPlayer1Name.Location = new System.Drawing.Point(332, 20);
            this.lblPlayer1Name.Name = "lblPlayer1Name";
            this.lblPlayer1Name.Size = new System.Drawing.Size(105, 17);
            this.lblPlayer1Name.TabIndex = 2;
            this.lblPlayer1Name.Text = "Player 1 Name:";
            // 
            // lblPlayer2Name
            // 
            this.lblPlayer2Name.AutoSize = true;
            this.lblPlayer2Name.Location = new System.Drawing.Point(333, 47);
            this.lblPlayer2Name.Name = "lblPlayer2Name";
            this.lblPlayer2Name.Size = new System.Drawing.Size(105, 17);
            this.lblPlayer2Name.TabIndex = 3;
            this.lblPlayer2Name.Text = "Player 2 Name:";
            this.lblPlayer2Name.Visible = false;
            // 
            // txtPlayer1Name
            // 
            this.txtPlayer1Name.Location = new System.Drawing.Point(444, 20);
            this.txtPlayer1Name.Name = "txtPlayer1Name";
            this.txtPlayer1Name.Size = new System.Drawing.Size(100, 22);
            this.txtPlayer1Name.TabIndex = 4;
            // 
            // txtPlayer2Name
            // 
            this.txtPlayer2Name.Location = new System.Drawing.Point(444, 48);
            this.txtPlayer2Name.Name = "txtPlayer2Name";
            this.txtPlayer2Name.Size = new System.Drawing.Size(100, 22);
            this.txtPlayer2Name.TabIndex = 5;
            this.txtPlayer2Name.Visible = false;
            // 
            // btnPlayer1Name
            // 
            this.btnPlayer1Name.Location = new System.Drawing.Point(550, 20);
            this.btnPlayer1Name.Name = "btnPlayer1Name";
            this.btnPlayer1Name.Size = new System.Drawing.Size(75, 23);
            this.btnPlayer1Name.TabIndex = 6;
            this.btnPlayer1Name.Text = "Ok";
            this.btnPlayer1Name.UseVisualStyleBackColor = true;
            this.btnPlayer1Name.Click += new System.EventHandler(this.btnPlayer1Ok_Click);
            // 
            // btnPlayer2Name
            // 
            this.btnPlayer2Name.Location = new System.Drawing.Point(550, 47);
            this.btnPlayer2Name.Name = "btnPlayer2Name";
            this.btnPlayer2Name.Size = new System.Drawing.Size(75, 23);
            this.btnPlayer2Name.TabIndex = 7;
            this.btnPlayer2Name.Text = "Ok";
            this.btnPlayer2Name.UseVisualStyleBackColor = true;
            this.btnPlayer2Name.Visible = false;
            this.btnPlayer2Name.Click += new System.EventHandler(this.btnPlayer2Name_Click);
            // 
            // btnPlayGame
            // 
            this.btnPlayGame.Location = new System.Drawing.Point(524, 76);
            this.btnPlayGame.Name = "btnPlayGame";
            this.btnPlayGame.Size = new System.Drawing.Size(101, 25);
            this.btnPlayGame.TabIndex = 8;
            this.btnPlayGame.Text = "Play Game";
            this.btnPlayGame.UseVisualStyleBackColor = true;
            this.btnPlayGame.Visible = false;
            this.btnPlayGame.Click += new System.EventHandler(this.btnPlayGame_Click);
            // 
            // pnlBoard
            // 
            this.pnlBoard.Location = new System.Drawing.Point(108, 107);
            this.pnlBoard.Name = "pnlBoard";
            this.pnlBoard.Size = new System.Drawing.Size(708, 417);
            this.pnlBoard.TabIndex = 9;
            // 
            // lblCurrentPlayer
            // 
            this.lblCurrentPlayer.AutoSize = true;
            this.lblCurrentPlayer.Location = new System.Drawing.Point(201, 83);
            this.lblCurrentPlayer.Name = "lblCurrentPlayer";
            this.lblCurrentPlayer.Size = new System.Drawing.Size(103, 17);
            this.lblCurrentPlayer.TabIndex = 10;
            this.lblCurrentPlayer.Text = "Current Player:";
            this.lblCurrentPlayer.Visible = false;
            // 
            // txtCurrentPlayer
            // 
            this.txtCurrentPlayer.Location = new System.Drawing.Point(311, 83);
            this.txtCurrentPlayer.Name = "txtCurrentPlayer";
            this.txtCurrentPlayer.ReadOnly = true;
            this.txtCurrentPlayer.Size = new System.Drawing.Size(100, 22);
            this.txtCurrentPlayer.TabIndex = 11;
            this.txtCurrentPlayer.Visible = false;
            // 
            // frmTicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 557);
            this.Controls.Add(this.txtCurrentPlayer);
            this.Controls.Add(this.lblCurrentPlayer);
            this.Controls.Add(this.pnlBoard);
            this.Controls.Add(this.btnPlayGame);
            this.Controls.Add(this.btnPlayer2Name);
            this.Controls.Add(this.btnPlayer1Name);
            this.Controls.Add(this.txtPlayer2Name);
            this.Controls.Add(this.txtPlayer1Name);
            this.Controls.Add(this.lblPlayer2Name);
            this.Controls.Add(this.lblPlayer1Name);
            this.Controls.Add(this.lblWelcome);
            this.Name = "frmTicTacToe";
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.frmTicTacToe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblPlayer1Name;
        private System.Windows.Forms.Label lblPlayer2Name;
        private System.Windows.Forms.TextBox txtPlayer1Name;
        private System.Windows.Forms.TextBox txtPlayer2Name;
        private System.Windows.Forms.Button btnPlayer1Name;
        private System.Windows.Forms.Button btnPlayer2Name;
        private System.Windows.Forms.Button btnPlayGame;
        private System.Windows.Forms.Panel pnlBoard;
        private System.Windows.Forms.Label lblCurrentPlayer;
        private System.Windows.Forms.TextBox txtCurrentPlayer;
    }
}

