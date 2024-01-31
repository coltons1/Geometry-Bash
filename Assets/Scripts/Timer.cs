using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Timer : MonoBehaviour
{
    public float targetTime = 00.5f;
    void Update(){

        targetTime -= Time.deltaTime;

        if (targetTime <= 0.0f)
        {
        timerEnded();
        }

    }

    public void timerEnded()
    {
        if(this.gameObject == GameObject.Find("Player 1")){
            this.gameObject.GetComponent<Player1>().meleeAttack();
            Destroy(this.gameObject.GetComponent<Timer>());
        }
        
    }


}