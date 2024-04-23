using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    private GameObject p1;
    private GameObject p2;
    //loads scene "SceneName"
    public void LoadScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
        /*if(GameObject.Find("Player 1") != null && GameObject.Find("Player 2") != null){
            p1 = GameObject.Find("Player 1");
            p2 = GameObject.Find("Player 2");
            if(SceneName == "Character Select" || SceneName == "Stage Select"){

                

                //allows players 1 and 2 to move
                p1.SetActive(false);
                p2.SetActive(false);
            }
            else{
                p1.SetActive(true);
                p2.SetActive(true);                
            }

        }*/
    }

    public void stopPlayerMovement(){
        Time.timeScale = 0;
    }
}
