
# Tic-Tac-Toe Game using C# and .NET Framework

## **Overview**

This is a simple Tic-Tac-Toe game developed using C# and the .NET Framework, utilizing Windows Forms to create an intuitive graphical user interface (GUI). The game allows two players to take turns playing as "X" and "O" on a 3x3 grid. The game handles win conditions, draws, and keeps track of player scores. Additionally, it provides options to restart the game or start a new match from scratch.

---

## **Features**

- **Player Turn Display:** The current player's turn is displayed to guide users as they take turns.
- **Win and Draw Detection:** The game automatically checks for win conditions (three identical marks in a row, column, or diagonal) and displays the result. If all nine squares are filled without a winner, it announces a draw.
- **Scoreboard:** The game keeps track of the number of wins for each player (X and O) and the number of draws.
- **Restart Game Option:** A "Restart" button allows players to reset the board and continue playing while keeping the scores intact.
- **New Game Option:** A "New Game" button resets the board and also clears the score, offering a fresh start for both players.
- **Button-based GUI:** The game board is a 3x3 grid of clickable buttons, where each button represents a cell.
- **Responsive UI:** Buttons change color when selected, indicating the active player. Winning cells are highlighted in green.

---

## **Game Mechanics**

The game board is made up of nine buttons arranged in a 3x3 grid. Each button can be clicked to place either an "X" or an "O", depending on the player's turn. The player switches after each move, and the game automatically checks for a win or draw after each turn.

### **Win Detection**

The game checks for eight possible winning combinations:
1. Three in a row horizontally (Rows 1, 2, or 3).
2. Three in a row vertically (Columns 1, 2, or 3).
3. Three in a diagonal (either top-left to bottom-right or top-right to bottom-left).

If a player wins, the winning buttons are highlighted in green, and the scoreboard is updated accordingly.

### **Draw Detection**

If all nine buttons are pressed without a winner, the game announces a draw and increments the draw count on the scoreboard.

---

## **Functionality Overview**

### **Methods and Functions**

1. **`PressBtn(Button b)`**  
   Handles the button press action, updating the text of the button to either "X" or "O" based on the player's turn, disables the button, and updates the turn display.

2. **`CheckWinner(Button bt1, Button bt2, Button bt3, string XO)`**  
   Checks if the given three buttons contain the same symbol ("X" or "O"). If so, it highlights the buttons and updates the score.

3. **`Winner()`**  
   Checks all possible winning conditions. If a win is detected, it announces the winner. If all buttons are filled with no winner, it declares a draw.

4. **`Enable_False()`**  
   Disables all buttons after a win or draw is detected to prevent further moves.

5. **`btnExit_Click(object sender, EventArgs e)`**  
   Closes the game when the "Exit" button is clicked.

6. **`btnRestart_Click(object sender, EventArgs e)`**  
   Resets the game board, keeping the current scores intact, allowing the players to start another round.

7. **`btnNewGame_Click(object sender, EventArgs e)`**  
   Resets both the game board and the scoreboard, allowing for a completely fresh game.

---

## **Technologies Used**

- **C#**
- **.NET Framework**
- **Windows Forms** for creating the graphical user interface (GUI)
- **Visual Studio** as the development environment

---

## **Installation and Usage**

1. Clone this repository:
   ```bash
   git clone https://github.com/your-username/tic-tac-toe-csharp.git
   ```

2. Open the project in **Visual Studio**.

3. Build the project:
   - Go to `Build` -> `Build Solution` (or press `Ctrl+Shift+B`).

4. Run the project:
   - Go to `Debug` -> `Start Debugging` (or press `F5`).

5. The game window will open, and you can start playing!

---

## **How to Play**

1. **Starting the Game:**  
   Player X starts the game. The player's turn will be displayed at the top of the window. Each player clicks on a button to place their "X" or "O" in the respective grid space.

2. **Winning the Game:**  
   The first player to align three identical marks (horizontally, vertically, or diagonally) wins the game.

3. **Draw Scenario:**  
   If all grid spaces are filled without any player forming a winning line, the game will declare a draw.

4. **Restarting or Starting a New Game:**  
   - Click the "Restart" button to reset the board while keeping the scores.
   - Click the "New Game" button to reset both the board and the scores.

5. **Exiting the Game:**  
   Click the "Exit" button to close the application.
