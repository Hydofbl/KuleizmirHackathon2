using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dön : MonoBehaviour
{
    public float rotationSpeed = 5f;
    
    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(transform.position, Vector3.up, rotationSpeed);
    }
}
