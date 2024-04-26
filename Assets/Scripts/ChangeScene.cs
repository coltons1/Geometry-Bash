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
    }

    public void stopPlayerMovement(){
        Time.timeScale = 0;
    }

    public void resumePlayerMovement(){
        Time.timeScale = 1;
    }
}
