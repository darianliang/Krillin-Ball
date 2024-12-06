using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalScript : MonoBehaviour
{
    private Scene scene;

    void Start()
    {
        scene = SceneManager.GetActiveScene();
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.GetComponent<Krillin>() == null)
        {
            return;
        }

        if (ScoreKeeper.scoreCount != 7)
        {
            return;
        }

        if (scene.name == "EasyMaze")
        {
            SceneManager.LoadScene("MediumMaze");
        }
        else if (scene.name == "MediumMaze") 
        {
            SceneManager.LoadScene("HardMaze");
        }
    }
}