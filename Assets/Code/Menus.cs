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

    public GameObject GameCompleteMenu;

    public GameObject InstructionsMenu;

    public TMP_Text levelCompleteButtonText;

    private bool paused;

    private bool instructionsup;

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

        GameCompleteMenu.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.JoystickButton9) || Input.GetKeyDown(KeyCode.Escape)) {
            if (StartMenu.activeInHierarchy || LevelCompleteMenu.activeInHierarchy) {
                return;
            }
            if (paused) {
                PauseMenu.SetActive(false);
                Time.timeScale = 1.0f;
            }
            else {
                if (instructionsup) {
                    PauseMenu.SetActive(false);
                }
                else {
                    PauseMenu.SetActive(true);
                }
                Time.timeScale = 0.0f;
            }

            paused = !paused;
        }

        if (Input.GetKeyDown(KeyCode.I)) {
            if (StartMenu.activeInHierarchy || LevelCompleteMenu.activeInHierarchy) {
                return;
            }
            if (instructionsup) {
                InstructionsMenu.SetActive(false);
                if (paused) {
                    PauseMenu.SetActive(true);
                }
                Time.timeScale = 1.0f;
            }
            else {
                InstructionsMenu.SetActive(true);
                if (paused) {
                    PauseMenu.SetActive(false);
                }
                Time.timeScale = 0.0f;
            }
            instructionsup = !instructionsup;
        }

        if (StartMenu.activeInHierarchy)
        {
            if (Input.GetKeyDown(KeyCode.JoystickButton4) || Input.GetKeyDown(KeyCode.JoystickButton5))
            {
                OnStart();
            }
        }
        else if (LevelCompleteMenu.activeInHierarchy)
        {
            if (Input.GetKeyDown(KeyCode.JoystickButton4))
            {
                StartOver();
            }
            else if (Input.GetKeyDown(KeyCode.JoystickButton5))
            {
                LoadNextLevel();
            }
        }
        else if (GameCompleteMenu.activeInHierarchy)
        {
            if (Input.GetKeyDown(KeyCode.JoystickButton4) || Input.GetKeyDown(KeyCode.JoystickButton5))
            {
                StartOver();
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
        if ((scene.name == "EasyMaze") || (scene.name == "MediumMaze"))
        {
            LevelCompleteMenu.SetActive(true);
        }
        else if (scene.name == "HardMaze")
        {
            GameCompleteMenu.SetActive(true);
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

    public void StartOver()
    {
        SceneManager.LoadScene("EasyMaze");
    }
}
