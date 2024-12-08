using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GoalScript : MonoBehaviour
{
    public UnityEvent OnGoal;
    private AudioSource sound;

    void Start() {
        sound = GetComponent<AudioSource>();
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
        sound.Play();
        OnGoal.Invoke();
    }
}