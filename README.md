# Game State Management

## Description
This project implements a **Game State Management System** using the **Memento Design Pattern**. It allows players to manage the state of their game, including saving, undoing, and viewing their progress history. The program is designed to demonstrate object-oriented principles, such as **Single Responsibility** and **Separation of Concerns**, while maintaining clean and modular code.

## Features
1. **Move Player**: The player can make moves (Up, Down, Left, Right) to progress in the game.
2. **Save Game State**: Save the current state of the game (player's position and points).
3. **Undo Last Action**: Restore the previous state using the undo feature.
4. **View current state**: Display currnet state of player and his points
5. **View History**: Display a history of saved game states with timestamps.
6. **Exit**: Exit the game at any time.

## Technologies Used
- **C# Programming Language**
- **Memento Design Pattern**
- **Object-Oriented Principles**

## How It Works
- **Game Class**: Represents the originator that holds the current game state.
- **Memento Class**: Saves the current state in an immutable object.
- **StateManagement Class**: Responsible for creating and restoring game states using mementos.
- **GameHistory Class**: Serves as the caretaker, storing and managing the history of mementos.

## Usage
Run the program and follow the instructions in the console. You can:
- Move the player to different directions.
- Save the game state after making progress.
- Undo actions to revert to a previous state.
- Check your progress history at any time.

## Purpose
This project is intended for learning and demonstrating:
- Effective use of design patterns.
- Proper management of game states.
- Building a simple yet interactive console application.
