using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController controller;
    public UIController ui_controller;
    public int points;
    private void Awake() {
        if (controller == null){
            controller = this;
        }else {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(this);
    }

    public void AddPoints(){
        points++;
        ui_controller.UpdatePoints(points);
        
        if(points >= 20){
            points = 0;
            ui_controller.SceneChange("Victory");
        }
    }
}
