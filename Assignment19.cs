using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment19 : MonoBehaviour
{
    [SerializeField]
    private float floatSpeed = 2f;

    [SerializeField]
    private float rotateSpeed = 50f;

    private float startY;

    void Start()
    {
        startY = transform.position.y;
    }

    void Update()
    {
        float newY = startY + (Mathf.Sin(Time.time * floatSpeed) * 0.5f);
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);

        transform.Rotate(Vector3.right * (rotateSpeed * Time.deltaTime));

    }
}
