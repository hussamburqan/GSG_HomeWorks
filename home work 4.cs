using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class homework4 : MonoBehaviour
{
    void Start()
    {
        int num = 5;
        for (int itera = 1; itera <= 10; itera++)
        {
            int res = Multiply(num, itera);
            Debug.Log(num + "x" + itera + "=" + res);
        }

    }
    int Multiply(int x, int itera)
    {
        return x * itera;
    }

}
