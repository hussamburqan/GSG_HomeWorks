using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        Player player = new Player("hussam", 100);
        Enemy enemy = new Enemy("ahmad", 100);

        Debug.Log("Player: " + player.CharacterName + ", Health: " + player.CharacterHealth);
        Debug.Log("Enemy: " + enemy.CharacterName + ", Health: " + enemy.CharacterHealth);

        player.Heal(20);

        enemy.Attack(player, 30);
    }
}
