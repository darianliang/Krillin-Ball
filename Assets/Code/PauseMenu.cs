using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    private bool paused;

    void Start()
    {
        gameObject.SetActive(false);

        paused = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.JoystickButton9))
        {
            Debug.Log("pause");

            if (paused)
            {
                gameObject.SetActive(false);
                Time.timeScale = 1.0f;
                
            }
            else
            {
                gameObject.SetActive(true);
                Time.timeScale = 0.0f;
            }

            paused = !paused;
        }
    }
}
