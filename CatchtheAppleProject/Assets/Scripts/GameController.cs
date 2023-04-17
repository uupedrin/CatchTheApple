using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController controller;
    public UIController ui_controller;
    public int points, lifes = 3;
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
            ResetValues();
            ui_controller.SceneChange("Victory");
        }
    }
    public void ReduceLifes(){
        lifes--;
        ui_controller.UpdateLifes(lifes);

        if(lifes <= 0){
            ResetValues();
            ui_controller.SceneChange("Defeat");
        }
    }
    public void ResetValues(){
        points = 0;
        lifes = 3;
    }
}
