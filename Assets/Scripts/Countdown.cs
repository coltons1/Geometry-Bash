using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Countdown : MonoBehaviour
{

    private float initialTime;
    private float currentTime;
    private bool timerRunning;
    public TextMeshProUGUI timerText;
    private string minutes;
    private string seconds;
    private ChangeScene cS;
    // Start is called before the first frame update
    void Start()
    {
        initialTime = 90.0f;
        timerText = GameObject.Find("timerText").GetComponent<TextMeshProUGUI>();
        currentTime = 0f;
        timerRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(timerRunning){
            currentTime = initialTime - Time.time;
            string minutes = ((int)currentTime / 60).ToString("00");
            string seconds = (currentTime % 60).ToString("00");
            timerText.text = minutes + ":" + seconds;
        }
        

        if(currentTime == 0.0){
            timerEnd();
        }
    }

    void timerEnd(){
        cS.LoadScene("Draw");
    }

    void stopTimer(){
        timerRunning = false;
        initialTime = 90.0f;
    }


}
