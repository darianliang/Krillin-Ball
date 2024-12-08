using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Krillin : MonoBehaviour
{
    private AudioSource sound;
    void Start() {
        sound = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Dragon Ball") {
            sound.Play();
        }
    }
}
