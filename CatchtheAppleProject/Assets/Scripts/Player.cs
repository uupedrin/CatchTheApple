using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float h;
    public float move_speed, run_speed;
    private SpriteRenderer boat_sprite;

    private void Start() {
        boat_sprite = gameObject.GetComponentInChildren<SpriteRenderer>();
    }

    private void Update() {
        PlayerMovement();
    }

    private void PlayerMovement(){
        h = Input.GetAxisRaw("Horizontal");
        Vector3 movement;

        if(h < 0){
            boat_sprite.flipX = false;
        }
        else if(h > 0){
            boat_sprite.flipX = true;
        }

        if((h < 0 && transform.position.x > -9.3f) || (h > 0 && transform.position.x < 9.3f)){
            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)){
            movement = Vector3.right * h * run_speed * Time.deltaTime;
        }else{
            movement = Vector3.right * h * move_speed * Time.deltaTime;
        }
        transform.position+= movement;
        }
        
    }

    private void OnCollisionEnter(Collision other) {
        GameController.controller.AddPoints();
    }
}
