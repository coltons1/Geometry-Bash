using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Timer: MonoBehaviour {

public float targetTime = 2;

void Update()
{
    targetTime -= Time.deltaTime;

    if (targetTime <= 0.0f)
    {
    timerEnded();
    }
}

void timerEnded()
{
   //do your stuff here.
   Debug.Log("Time");
}


}
