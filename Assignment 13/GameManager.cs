using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()        
    {
        player playerOne = new player();
        player playerTwo = new player();

        playerOne.InitializePlayer("GinoMachino", 50);
        playerTwo.InitializePlayer("LilAggey", 60);

        playerOne.Heal(20);
        playerTwo.Heal(15);

        playerOne.Heal(true);
        playerTwo.Heal(true);

        player.ShowPlayerCount();
    }

}
