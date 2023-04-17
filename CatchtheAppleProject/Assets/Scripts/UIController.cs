using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Text txt_points, txt_lifes;

    private void Start() {
        GameController.controller.ui_controller = this;
    }
    public void SceneChange(string scene_to_go){
        SceneManager.LoadScene(scene_to_go);
    }
    public void PlayAgain(){
        GameController.controller.ResetValues();
    }
    public void QuitGame(){
        Application.Quit();
    }

    public void UpdatePoints(int points){
        txt_points.text = "Points: " + points;
    }

    public void UpdateLifes(int lifes){
        txt_lifes.text = "Lifes: " + lifes;
    }
}
