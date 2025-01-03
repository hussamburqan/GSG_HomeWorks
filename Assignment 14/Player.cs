using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{

    //public Player(string name, int health)
    //{
    //    this.name = name;
    //    this.health = health;

    //}

    public Player(string name, int health) : base(name, health) { } //correct 

    public void Heal(int amount)
    {
        CharacterHealth += amount;
        Debug.Log("Player heal " + amount + "\n" + "health: " + CharacterHealth);
    }
}
