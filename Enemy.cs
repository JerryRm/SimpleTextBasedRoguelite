// Represents an enemy, their stats, and actions in the game.
using System;

public class Enemy
{
    // The enemy's name
    public string Name { get; set; }
    // The enemy's current and maximum health points
    public int HP { get; set; }
    public int MaxHP { get; set; }
    // The enemy's attack and defense stats
    public int Attack { get; set; }
    public int Defense { get; set; }

    // Constructor initializes the enemy with given stats
    public Enemy(string name, int maxHP, int attack, int defense)
    {
        Name = name;
        MaxHP = maxHP;
        HP = MaxHP;
        Attack = attack;
        Defense = defense;
    }

    // Method for the enemy to take damage
    // Returns true if the enemy is still alive after taking damage
    public bool TakeDamage(int amount)
    {
        int damage = Math.Max(1, amount - Defense);
        HP -= damage;
        if (HP < 0) HP = 0;
        return HP > 0;
    }

    // Returns a string with the enemy's current stats for display
    public string GetStats()
    {
        return $"{Name} - HP: {HP}/{MaxHP} | ATK: {Attack} | DEF: {Defense}";
    }
}
