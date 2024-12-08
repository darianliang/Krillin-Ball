using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonBall : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(new Vector3(30, 60, 90) * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Krillin") {
            Destroy(gameObject);
            
            ScoreKeeper.scoreCount += 1;
        }
    }
}
