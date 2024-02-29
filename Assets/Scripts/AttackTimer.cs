using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class AttackTimer : MonoBehaviour
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
            this.gameObject.GetComponent<Player1>().isMeleeAttacking = false;

            Destroy(this.gameObject.GetComponent<AttackTimer>());

        }
        if(this.gameObject == GameObject.Find("Player 2")){
            this.gameObject.GetComponent<Player2>().isMeleeAttacking = false;

            Destroy(this.gameObject.GetComponent<AttackTimer>());
        }
    }


}
