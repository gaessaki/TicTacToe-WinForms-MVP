using System.Collections.Generic;
using System.Windows.Forms;

namespace TicTacToe
{
    public interface ITicTacToeForm
    {

        TableLayoutPanel ButtonGrid { get; }

        Presenter.GamePresenter Presenter { set; }
    }
}