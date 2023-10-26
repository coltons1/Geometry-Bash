using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{

    public Slider p1Healthbar;
    public int hpValue = 100;

    //BoxCollider2D floor;

    // Start is called before the first frame update
    void Start()
    {
        //floor = BottomPlatform.GetComponent<BoxCollider2D>();
    
    }
    
    // Update is called once per frame
    void Update()
    {

    }

    public int getHealth(){
        return hpValue;
    }
}
