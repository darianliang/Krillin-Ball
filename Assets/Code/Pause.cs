using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    private bool paused;

    public GameObject pauseScreen;

    void Start()
    {
        paused = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.JoystickButton9))
        {
            Debug.Log("pause");

            if (paused)
            {
                pauseScreen.SetActive(false);
                Time.timeScale = 1.0f;
                
            }
            else
            {
                pauseScreen.SetActive(true);
                Time.timeScale = 0.0f;
            }

            paused = !paused;
        }
    }
}
