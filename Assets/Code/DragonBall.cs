using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonBall : MonoBehaviour
{
    
    void FixedUpdate()
    {

    }
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Krillin") {
            Destroy(gameObject);
            ScoreKeeper.scoreCount += 1;
        }
    }
}
