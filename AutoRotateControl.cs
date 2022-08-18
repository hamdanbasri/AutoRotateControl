using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotateControl : MonoBehaviour
{

    public bool PosX, NegX, PosY, NegY, PosZ, NegZ;

    public float speed = 10f;

    void Start()
    {

    }

    void Update()
    {
        if (PosX == true)
        {
            transform.Rotate(Vector3.right, speed * Time.deltaTime);
        }

        if (NegX == true)
        {
            transform.Rotate(Vector3.left, speed * Time.deltaTime);
        }

        if (PosY == true)
        {
            transform.Rotate(Vector3.up, speed * Time.deltaTime);
        }

        if (NegY == true)
        {
            transform.Rotate(Vector3.down, speed * Time.deltaTime);
        }

        if (PosZ == true)
        {
            transform.Rotate(Vector3.back, speed * Time.deltaTime);
        }

        if (NegZ == true)
        {
            transform.Rotate(Vector3.forward, speed * Time.deltaTime);
        }        
    }
}
