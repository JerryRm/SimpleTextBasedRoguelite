// GameState.cs
// Enum to represent the current state of the game (menu, exploring, combat, etc)

public enum GameState
{
    Menu,       // Main menu or start screen
    Exploring,  // Player is exploring the dungeon
    Combat,     // Player is in combat with an enemy
    GameOver,   // Player has lost
    Victory     // Player has won
}
