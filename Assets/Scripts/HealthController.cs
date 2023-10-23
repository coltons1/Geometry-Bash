using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{

    public Slider p1Healthbar;
    int hpValue = 100;

    //BoxCollider2D floor;

    // Start is called before the first frame update
    void Start()
    {
        //floor = BottomPlatform.GetComponent<BoxCollider2D>();
    
    }


    void OnCollisionEnter(Collision Collider){
        hpValue -= 5;
        p1Healthbar.value = hpValue;
        //Debug.Log("taken damage");
    }

    // Update is called once per frame
    void Update()
    {
        //OnCollisionEnter(floor);
    }
}
