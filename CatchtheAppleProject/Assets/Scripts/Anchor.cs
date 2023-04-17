using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anchor : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Player"){
            GameController.controller.ReduceLifes();
            Destroy(this.gameObject);
        }
        else if(other.tag == "Destroyer"){
            Destroy(this.gameObject);
        }
    }
}
