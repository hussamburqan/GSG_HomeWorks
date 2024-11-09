using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player 
{
    public string playerName; 
    public int health;
    public static int playerCount = 0;


    public void InitializePlayer(string name, int initialHealth)
    {
        
        playerName = name;
        health = initialHealth;
        playerCount++;

        Debug.Log("InitializePlayer: " + "player Name: " + playerName + " health: " + health);

    }

    public void Heal(int amount)
    {

        if (health > 0)
        {
            health += amount;
            Debug.Log("health = " + health);
        }
        else
        {
            //player is dead :( you don't need heal ,you need to rest
            //
            Debug.Log("player is dead ");

        }
    }

    public void Heal(bool fullRestore)
    {
        if (fullRestore)
        {

            health = 100;
            Debug.Log("Player: " + playerName + " restord his full health" + health);
        }
    }


    public static void ShowPlayerCount()
    {
        Debug.Log("Current number of players: " + playerCount);
    }
}
