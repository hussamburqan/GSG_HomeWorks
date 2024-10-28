using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class homeworkscript2 : MonoBehaviour
{
    void Start()
    {
        int livesForPlayer = 3;

        while (livesForPlayer > 0) 
        {
            if(livesForPlayer == 3) 
            { 
                Debug.Log("have many lives");
            }
            else if (livesForPlayer == 1) 
            { 
                Debug.Log("have many lives");
            }

            livesForPlayer--;
        }

        Debug.Log("Game over");
    }
}
