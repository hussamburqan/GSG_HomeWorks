using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment20 : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.left * 2.5f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.right * 2.5f * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down * 60 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * 60 * Time.deltaTime);

        }
    }
}