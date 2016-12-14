using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Model
{
    public interface IGridModel
    {
        void NewGrid();
        void SetPiece(char piece, int row, int col);
        char GetPiece(int row, int col);
        bool PlayerOneTurn { get; set; }

    }
}
