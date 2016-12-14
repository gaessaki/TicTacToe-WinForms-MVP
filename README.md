# TicTacToe-WinForms-MVP
A Tic Tac Toe game built in WinForms using the Model-View-Presenter Pattern

>"Players soon discover that best play from both parties leads to a draw. Hence, Tic-tac-toe is most often played by young children." —Wikipedia

![TicTacToe in-game picture](https://cloud.githubusercontent.com/assets/627640/21169184/06371c38-c188-11e6-9a4b-216f2e12538f.PNG)

## Playing Instructions

This iteration of the classic game is played with two players and with standard rules. Simply click on the desired square to place an X or O. To start a new game after finishing or aborting a prior one, simply click 'Restart'.

## Understanding the Code

All of the methods have been documented in the code. The code was designed around the [Model–View–Presenter](https://en.wikipedia.org/wiki/Model%E2%80%93view%E2%80%93presenter) pattern. This was somewhat redudant, but done purely to demonstrate best practices. The model stores the game grid along with the player turn. The view stores the UI state and displays the model. The presenter obtains data from the model and formats it for display to the view. The application boots up in Program.cs and further code is split up in the View, Model and Presenter folders.
