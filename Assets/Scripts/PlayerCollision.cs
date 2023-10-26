using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    HealthController healthController;
    void Awake()
    {
        healthController = GameObject.Find("p1Healthbar").GetComponent<HealthController>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "BottomPlatform")
        {
            Debug.Log("enter");
            healthController.hpValue -= 5;
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.name == "BottomPlatform")
        {
            Debug.Log("stay");
        }
    }
    
    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.name == "BottomPlatform")
        {
            Debug.Log("exit");    
        }
    }

    void Update()
    {
        
    }
}
