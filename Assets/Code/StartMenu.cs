using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenu : MonoBehaviour
{
    void Start()
    {
        gameObject.SetActive(true);

        Time.timeScale = 0.0f;
    }

    public void OnStart()
    {
        gameObject.SetActive(false);

        Time.timeScale = 1.0f;
    }
}
