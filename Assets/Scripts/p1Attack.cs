using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p1Attack : MonoBehaviour
{

    HealthController healthController;
    private int hitRange = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)){
            //punch();
        }
    }

    /*void punch(){
        RaycastHit hit;
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        Vector3 origin = transform.position;

        if(Physics.Raycast(origin, forward, hitRange, out hit))
        {
            if(hit.transform.gameObject.tag == "Enemy")
            {
                hit.transform.gameObject.SendMessage("takeDamage", 5);
            }
        }
    }*/
}
