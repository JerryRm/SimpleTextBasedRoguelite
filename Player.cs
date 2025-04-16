// Represents the player character, their stats, and actions in the game.
using System;
using System.Collections.Generic;

public class Player
{
    // The player's name
    public string Name { get; set; }
    // The player's current and maximum health points
    public int HP { get; set; }
    public int MaxHP { get; set; }
    // The player's attack and defense stats
    public int Attack { get; set; }
    public int Defense { get; set; }
    // The player's inventory (can be expanded later)
    public List<string> Inventory { get; set; }

    // Constructor initializes the player with default stats
    public Player(string name = "Hero")
    {
        Name = name;
        MaxHP = 20;
        HP = MaxHP;
        Attack = 5;
        Defense = 2;
        Inventory = new List<string>();
    }

    // Method for the player to take damage
    // Returns true if the player is still alive after taking damage
    public bool TakeDamage(int amount)
    {
        // Damage is reduced by defense, but always at least 1
        int damage = Math.Max(1, amount - Defense);
        HP -= damage;
        if (HP < 0) HP = 0;
        return HP > 0;
    }

    // Method to heal the player
    public void Heal(int amount)
    {
        HP += amount;
        if (HP > MaxHP) HP = MaxHP;
    }

    // Returns a string with the player's current stats for display
    public string GetStats()
    {
        return $"{Name} - HP: {HP}/{MaxHP} | ATK: {Attack} | DEF: {Defense}";
    }
}
