using System;
using System.Windows.Forms;
using TicTacToe.Model;
using TicTacToe.Presenter;

namespace TicTacToe
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// Creates a new view and model and wires them with a presenter.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            TicTacToeForm ticTacToeForm = new TicTacToeForm();
            GamePresenter presenter = new GamePresenter(ticTacToeForm, new GridModel());

            Application.Run(ticTacToeForm);
        }
    }
}
