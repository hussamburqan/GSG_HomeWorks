using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    public Enemy(string name, int health)
    {
        this.name = name;
        this.health = health;
    }

    //public Enemy(string name, int health) : base(name, health) { }//correct


    public void Attack(Character target, int damage)
    {
        target.CharacterHealth -= damage;
        Debug.Log(" attacking " + target.CharacterName + " for " + damage + " damage. " + "\n now " + target.CharacterName + "'s  health is: " + target.CharacterHealth);
    }

}
