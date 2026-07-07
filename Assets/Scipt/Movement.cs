using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float Speed = 10;
    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * Speed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * Speed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * Speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * Speed);
        }

        if (Input.GetKey(KeyCode.F))
        {
        transform.Translate(Vector3.up * Time.deltaTime * Speed);
        }

        if (Input.GetKey(KeyCode.X))
        {
            transform.Translate(Vector3.down * Time.deltaTime * Speed);
        }
    }


}
