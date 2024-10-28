using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class homework3 : MonoBehaviour
{
    void Start()
    {

        //Ex : 1 

        int x;
        Debug.Log(" Ex : 1 ");
        Debug.Log("=====================");

        while (true)
        {
             x = Random.Range(1, 21);

            if (x == 5)
            {

                continue;
            }
            Debug.Log(x);

            if (x == 15)
            {
                break;
            }

        }

        Debug.Log("=====================");
        Debug.Log(" Ex : 2 ");
        Debug.Log("=====================");

        //Ex : 2 

        string[] array = new string[] { "Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird" };
        int loops = 0;
        string fannysentice = "";
        while (loops < array.Length) {



            fannysentice += array[Random.Range(0,array.Length)] + " ";

            loops++;
        }
        Debug.Log("FannySentice = " + fannysentice);
        Debug.Log("=====================");
    }
}
