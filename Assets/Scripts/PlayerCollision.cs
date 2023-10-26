using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    HealthController healthController;
    public GameObject hpValue;

    void Awake()
    {
        healthController = GameObject.Find("p1Healthbar").GetComponent<HealthController>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "BottomPlatform")
        {
            //hpValue -= 10; 
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
