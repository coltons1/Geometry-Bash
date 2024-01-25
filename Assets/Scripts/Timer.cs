using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Timer : MonoBehaviour
{
    public float targetTime = 5.0f;

    void Update(){

        targetTime -= Time.deltaTime;

        if (targetTime <= 0.0f)
        {
        timerEnded();
        }

    }

    public void timerEnded()
    {
        
    }


}