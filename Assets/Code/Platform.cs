using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float xRotationRange = 30f;

    public float zRotationRange = 30f;

    void Start()
    {

    }

    void FixedUpdate()
    {
        float xRotation = Input.GetAxis("Horizontal") * xRotationRange;
        float zRotation = Input.GetAxis("Vertical") * zRotationRange;

        Quaternion rotation = Quaternion.Euler(xRotation, 0.0f, zRotation);

        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * 2.5f);
    }
}
