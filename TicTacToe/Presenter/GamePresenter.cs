using System.Drawing;
using System.Windows.Forms;
using TicTacToe.Model;

namespace TicTacToe.Presenter
{
    public class GamePresenter
    {
        private readonly ITicTacToeForm view;
        private readonly IGridModel model;
        public GamePresenter(ITicTacToeForm view, IGridModel model)
        {
            this.view = view;
            this.model = model;

            this.view.Presenter = this;
        }

        /// <summary>
        /// Creates a new empty grid in the model and resets the view controls.
        /// </summary>
        internal void NewGame()
        {
            model.NewGrid();
            var gridPanel = view.ButtonGrid;

            foreach (Button b in gridPanel.Controls)
            {
                int row = gridPanel.GetRow(b);
                int col = gridPanel.GetColumn(b);

                b.Text = model.GetPiece(row, col) + "";
                b.UseVisualStyleBackColor = true;
            }
            gridPanel.Enabled = true;
        }

        /// <summary>
        /// Displays a temporary marker on the board at the specified cell.
        /// </summary>
        /// <param name="row">The row of the cell to highlight.</param>
        /// <param name="col">The column of the cell to highlight.</param>
        internal void ShowTemporaryPlayerChar(int row, int col)
        {
            char c = model.GetPiece(row, col);
            var gridPanel = view.ButtonGrid;
            
            if (c == '\0')
            {
                Button b = (Button)gridPanel.GetControlFromPosition(col, row);
                if (model.PlayerOneTurn)
                {
                    b.ForeColor = Color.LightBlue;
                    b.Text = "X";
                }
                else
                {
                    b.ForeColor = Color.LightCoral;
                    b.Text = "O";
                }
            }
        }

        /// <summary>
        /// Hides the temporary marker on the board at the specified cell.
        /// </summary>
        /// <param name="row">The row of the cell to no longer highlight.</param>
        /// <param name="col">The column of the cell to no longer highlight.</param>
        internal void HideTemporaryPlayerChar(int row, int col)
        {
            char c = model.GetPiece(row, col);
            var gridPanel = view.ButtonGrid;

            if (c == '\0')
            {
                Button b = (Button)gridPanel.GetControlFromPosition(col, row);
                b.Text = "";
            }
        }

        /// <summary>
        /// Plays a turn, which consists of placing the user's marker in the model and on the view at the desired spot (if possible), informing the model that the next turn is starting and determining if there are any wins or ties.
        /// </summary>
        /// <param name="row">The row of the cell that the player wishes to place a marker on.</param>
        /// <param name="col">The column of the cell that the player wishes to place a marker on.</param>
        internal void PlayTurn(int row, int col)
        {
            if (model.GetPiece(row, col) != '\0')
                return;

            char c = model.PlayerOneTurn ? 'X' : 'O';
            var gridPanel = view.ButtonGrid;

            model.SetPiece(c, row, col);

            Button b = (Button)gridPanel.GetControlFromPosition(col, row);
            if (model.PlayerOneTurn)
            {
                b.ForeColor = Color.Blue;
                b.Text = model.GetPiece(row, col) + "";
            }
            else
            {
                b.ForeColor = Color.Crimson;
                b.Text = model.GetPiece(row, col) + "";
            }
            model.PlayerOneTurn = !model.PlayerOneTurn;
            switch (IsWinOrTie())
            {
                case 'X':
                    MessageBox.Show("Congrats to Player X! Press 'Restart' to play a new round.", "X has won");
                    gridPanel.Enabled = false;
                    break;
                case 'O':
                    MessageBox.Show("Congrats to Player O! Press 'Restart' to play a new round.", "O has won");
                    gridPanel.Enabled = false;
                    break;
                case 't':
                    MessageBox.Show("It's a tie! Press 'Restart' to play a new round.", "Tie");
                    gridPanel.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Determines if there is a winner by checking the grid rows, columns and diagonals. If there is none, checks whether the game should continue, or that there is a tie.
        /// </summary>
        /// <returns>Returns a character indicating who the winner is, if there is one. Otherwise returns a 't' for tie or an '\\0' for no action.</returns>
        private char IsWinOrTie()
        {
            for (int i = 0; i < 3; i++)
            {
                if (model.GetPiece(i, 0) != '\0' && model.GetPiece(i, 0) == model.GetPiece(i, 1) && model.GetPiece(i, 1) == model.GetPiece(i, 2))
                {
                    HighlightWin(i, 0, i, 1, i, 2);
                    return model.GetPiece(i, 0);
                }
                if (model.GetPiece(0, i) != '\0' && model.GetPiece(0, i) == model.GetPiece(1, i) && model.GetPiece(1, i) == model.GetPiece(2, i))
                {
                    HighlightWin(0, i, 1, i, 2, i);
                    return model.GetPiece(0, i);
                }
            }
            if (model.GetPiece(0, 0) != '\0' && model.GetPiece(0, 0) == model.GetPiece(1, 1) && model.GetPiece(1, 1) == model.GetPiece(2, 2))
            {
                HighlightWin(0, 0, 1, 1, 2, 2);
                return model.GetPiece(1, 1);
            }
            if (model.GetPiece(0, 2) != '\0' && model.GetPiece(0, 2) == model.GetPiece(1, 1) && model.GetPiece(2, 0) == model.GetPiece(1, 1))
            {
                HighlightWin(0, 2, 1, 1, 2, 0);
                return model.GetPiece(1, 1);
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (model.GetPiece(i, j) == '\0')
                        return '\0';
                }
            }
            return 't';
        }

        /// <summary>
        /// Highlights the boxes on the game board where the winning markers are situated.
        /// </summary>
        /// <param name="a">Row of the 1st button.</param>
        /// <param name="b">Column of the 1st button.</param>
        /// <param name="c">Row of the 2nd button.</param>
        /// <param name="d">Column of the 2nd button.</param>
        /// <param name="e">Row of the 3rd button.</param>
        /// <param name="f">Column of the 3rd button.</param>
        private void HighlightWin(int a, int b, int c, int d, int e, int f)
        {
            var gridPanel = view.ButtonGrid;

            Button b0 = (Button)gridPanel.GetControlFromPosition(b, a);
            Button b1 = (Button)gridPanel.GetControlFromPosition(d, c);
            Button b2 = (Button)gridPanel.GetControlFromPosition(f, e);

            Color color = model.PlayerOneTurn ? Color.LightCoral : Color.LightBlue;

            b0.BackColor = b1.BackColor = b2.BackColor = color;
        }
    }
}
