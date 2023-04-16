using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Treasure : MonoBehaviour
{
    Rigidbody rb;
    private void Start() {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision other) {
        float posx = Random.Range(-9,9);
        float posy = Random.Range(7,8);

        transform.position = new Vector3(posx, posy, 0);
        rb.velocity = Vector3.zero;
    }
}
