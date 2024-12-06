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

        Debug.Log(scene.name);
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.GetComponent<Krillin>() == null)
        {
            return;
        }

        if (scene.name == "EasyMaze")
        {
            SceneManager.LoadScene("MediumMaze");
        }
        else if (scene.name == "MediumMaze") {
            SceneManager.LoadScene("HardMaze");
        }
    }
}