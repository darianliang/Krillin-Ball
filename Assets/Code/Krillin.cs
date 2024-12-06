using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Krillin : MonoBehaviour
{
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        // if (other.gameObject.tag == "Dragon Ball") {
        //     ScoreKeeper.scoreCount += 1;
        // }
    }
}
