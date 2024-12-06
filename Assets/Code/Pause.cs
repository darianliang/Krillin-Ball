using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public void Setup() {
        gameObject.SetActive(true);
    }
    public void Takedown() {
        gameObject.SetActive(false);
    }
}
