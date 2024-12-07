using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GoalScript : MonoBehaviour
{
    public UnityEvent OnGoal;

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

        OnGoal.Invoke();
    }
}