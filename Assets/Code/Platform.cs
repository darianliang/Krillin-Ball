using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Platform : MonoBehaviour
{
    public float xRotationRange = 30f;

    public float zRotationRange = 30f;

    public Pause pause;

    public bool paused = false;

    void Start()
    {

    }

    void Update() {
        if (!paused) {
            if (Input.GetKeyDown("Submit")) {
                pause.Setup(); 
                Time.timeScale = 0.0f;
                paused = true;
            }
        }
        else {
            if (Input.GetKeyDown("Submit")) {
                pause.Takedown();
                Time.timeScale = 1.0f;
                paused = false;
            }
        }

    }

    void FixedUpdate()
    {
        float xRotation = Input.GetAxis("Vertical") * xRotationRange;
        float zRotation = Input.GetAxis("Horizontal") * zRotationRange * -1;

        Quaternion rotation = Quaternion.Euler(xRotation, 0.0f, zRotation);

        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * 2.5f);

    }
}
