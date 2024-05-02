using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Countdown : MonoBehaviour
{

    private float initialTime;
    private float currentTime;
    private bool timerRunning;
    public TextMeshProUGUI timerText;
    private string minutes;
    private string seconds;
    public bool hasRun;

    // Start is called before the first frame update
    void Start()
    {
        if(GameObject.Find("timerText") != null){
            initialTime = 5.0f;
            timerText = GameObject.Find("timerText").GetComponent<TextMeshProUGUI>();
            currentTime = 0f;
            timerRunning = true;
            hasRun = false;
            Debug.Log("Timer Started");
        }

    }

    // Update is called once per frame
    void Update()
    {

        if(timerRunning == true){
            hasRun = false;
            currentTime = initialTime - Time.timeSinceLevelLoad;
            string minutes = ((int)currentTime / 60).ToString("00");
            string seconds = (currentTime % 60).ToString("00");
            timerText.text = minutes + ":" + seconds;
        }
        
        if(currentTime <= 0.0 && hasRun == false){
            Debug.Log("Checking Time End");
            timerRunning = false;
            timerEnd();
            Destroy(timerText);
            
        }

    }

    public void timerEnd(){
        if(hasRun == false){
            initialTime = 90.0f;
            onCountdownEnd();
            hasRun = true;
            Debug.Log("Timer End Ran");
        }
    }

    public void onCountdownEnd(){
        SceneManager.LoadScene("Draw");
    }
}
