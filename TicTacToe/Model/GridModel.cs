namespace TicTacToe.Model
{
    class GridModel : IGridModel
    {
        private char[,] grid;
        private bool playerOneTurn;

        /// <summary>
        /// Gets and sets the boolean indicating whether it's the first players turn.
        /// </summary>
        public bool PlayerOneTurn 
        {
            get { return playerOneTurn; }
            set { playerOneTurn = value; }
        }

        public GridModel()
        {
            grid = new char[3, 3];
            playerOneTurn = true;
        }

        /// <summary>
        /// Creates a new empty game grid and gives the turn to the first player.
        /// </summary>
        public void NewGrid()
        {
            grid = new char[3, 3];
            playerOneTurn = true;
        }

        /// <summary>
        /// Sets the player's marker on the specified grid square.
        /// </summary>
        /// <param name="piece">Character representing the players marker. Should be 'X' or 'O'.</param>
        /// <param name="row">The row of the square that the marker should be placed on.</param>
        /// <param name="col">The column of the square that the marker should be placed on.</param>
        public void SetPiece(char piece, int row, int col)
        {
            grid[row, col] = piece;
        }

        /// <summary>
        /// Gets the player's marker on the specified grid square.
        /// </summary>
        /// <param name="row">The row of the square in question.</param>
        /// <param name="col">The column of the square in question.</param>
        /// <returns>The character on the specified grid square.</returns>
        public char GetPiece(int row, int col)
        {
            return grid[row, col];
        }
    }
}
