using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TicTacToe.Presenter;

namespace TicTacToe
{
    public partial class TicTacToeForm : Form, ITicTacToeForm
    {
        /// <summary>
        /// Initializes the game and sets event handlers for each button.
        /// Additionally, displays a short instruction message to the players.
        /// </summary>
        public TicTacToeForm()
        {
            InitializeComponent();
            foreach (Button b in this.gridPanel.Controls)
            {
                b.MouseEnter += B_MouseEnter;
                b.MouseLeave += B_MouseLeave;
                b.MouseClick += B_MouseClick;
            }
            MessageBox.Show("1. Click any square to place a piece\n2. Take turns with a friend\n3. Have fun! ", "How to play");
        }

        /// <summary>
        /// Gets and sets the presenter for the view.
        /// </summary>
        public GamePresenter Presenter { private get; set; }

        /// <summary>
        /// Gets the TableLayoutPanel containing the game board's squares (buttons).
        /// </summary>
        public TableLayoutPanel ButtonGrid
        {
            get { return gridPanel; }
        }

        /// <summary>
        /// Event handler for when the player's mouse moves into a game square.
        /// Temporarily displays the player's marker on the square with reduced opacity.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void B_MouseEnter(object sender, EventArgs e)
        {
            Button button = sender as Button;

            int row = gridPanel.GetRow(button);
            int col = gridPanel.GetColumn(button);
            Presenter.ShowTemporaryPlayerChar(row, col);

        }

        /// <summary>
        /// Event handler for when the player's mouse moves out of a game square.
        /// Removes the temporary marker that was previously displayed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void B_MouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;

            int row = gridPanel.GetRow(button);
            int col = gridPanel.GetColumn(button);
            Presenter.HideTemporaryPlayerChar(row, col);

        }

        /// <summary>
        /// Attempts to place a marker on the specified square. 
        /// No action taken if the square is already filled.
        /// Otherwise hands the turn to the other player.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void B_MouseClick(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;

            int row = gridPanel.GetRow(button);
            int col = gridPanel.GetColumn(button);
            Presenter.PlayTurn(row, col);
        }

        /// <summary>
        /// Displays a message box with the author and license information.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Mansib Rahman on 12/13/2016.\n\nLicensed under the MIT License. License text available under LICENSE.", "About");
        }

        /// <summary>
        /// Resets the board and starts a new game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presenter.NewGame();
        }
    }
}
