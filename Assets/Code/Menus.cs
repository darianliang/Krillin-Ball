using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Menus : MonoBehaviour
{
    public GameObject StartMenu;

    public GameObject PauseMenu;

    public GameObject LevelCompleteMenu;

    public TMP_Text levelCompleteButtonText;

    private bool paused;

    private Scene scene;

    void Start()
    {
        scene = SceneManager.GetActiveScene();

        if (scene.name == "EasyMaze")
        {
            StartMenu.SetActive(true);

            Time.timeScale = 0.0f;
        }
        else
        {
            StartMenu.SetActive(false);

            Time.timeScale = 1.0f;
        }

        PauseMenu.SetActive(false);

        LevelCompleteMenu.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.JoystickButton9) || Input.GetKeyDown(KeyCode.Escape))
        {
            if (StartMenu.activeInHierarchy || LevelCompleteMenu.activeInHierarchy)
            {
                return;
            }

            if (paused)
            {
                PauseMenu.SetActive(false);
                Time.timeScale = 1.0f;
            }
            else
            {
                PauseMenu.SetActive(true);
                Time.timeScale = 0.0f;
            }

            paused = !paused;
        }

        if (Input.GetKeyDown(KeyCode.JoystickButton1))
        {
            if (StartMenu.activeInHierarchy)
            {
                OnStart();
            }
            else if (LevelCompleteMenu.activeInHierarchy)
            {
                Debug.Log("what");
                LoadNextLevel();
            }
        }
    }

    public void OnStart()
    {
        StartMenu.SetActive(false);

        Time.timeScale = 1.0f;
    }

    public void DisplayLevelComplete()
    {
        LevelCompleteMenu.SetActive(true);

        if ((scene.name == "EasyMaze") || (scene.name == "MediumMaze"))
        {
            levelCompleteButtonText.text = "Next Level";
        }
        else if (scene.name == "HardMaze")
        {
            levelCompleteButtonText.text = "Try Again";
        }

        Time.timeScale = 0.0f;
    }

    public void LoadNextLevel()
    {
        if (scene.name == "EasyMaze")
        {
            SceneManager.LoadScene("MediumMaze");
        }
        else if (scene.name == "MediumMaze")
        {
            SceneManager.LoadScene("HardMaze");
        }
        else if (scene.name == "HardMaze")
        {
            SceneManager.LoadScene("EasyMaze");
        }
    }
}
