using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnchorSpawner : MonoBehaviour
{
    public GameObject anchor;
    public float anchor_spawn_rate, anchor_spawn_chance;
    private void Start() {
        InvokeRepeating("DropAnchor",2f,anchor_spawn_rate);
        if (anchor_spawn_chance > 100){
            anchor_spawn_chance = 100;
        }
        if (anchor_spawn_chance < 0){
            anchor_spawn_chance = 0;
        }
    }
    private void DropAnchor(){
        float drop = Random.Range(0,100);
        if(drop <= anchor_spawn_chance){
            float posx = Random.Range(-9,9);
            float posy = Random.Range(7,8);
            Vector3 temp_transform = new Vector3(posx, posy, 0); 
            GameObject temp_anchor = Instantiate(anchor,temp_transform, transform.rotation);
        }
    }
}
