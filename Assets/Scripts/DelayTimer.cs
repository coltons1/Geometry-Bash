using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DelayTimer : MonoBehaviour
{
    public float targetTime = 100f;
    public void setTimer(float time){
        targetTime = time;
    }
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
            Destroy(this.gameObject.GetComponent<DelayTimer>());
        }
        if(this.gameObject == GameObject.Find("Player 2")){
            this.gameObject.GetComponent<Player2>().meleeAttack();
            Destroy(this.gameObject.GetComponent<DelayTimer>());
        }
    }


}