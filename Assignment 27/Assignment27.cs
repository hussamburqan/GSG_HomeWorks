using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

namespace Assignment27 {
    public class Assignment27 : MonoBehaviour
    {

        void Start()
        {
            int a = 0;
            int b = 0;
            CallByValue(a);
            Debug.Log($"First integer after CallByValue : {a}");

            CallByReference(ref b);
            Debug.Log($"Second integer after CallByReference : {b}");

            int c;
            CallUsingOut(out c);
            Debug.Log($"Third integer after CallUsingOut : {c}");

        }

        void CallByValue(int number)
        {
            number += 10;

        }
        void CallByReference(ref int number)
        {
            number += 20;

        }
        void CallUsingOut(out int number)
        {
            number = 30;

        }

    }
}
