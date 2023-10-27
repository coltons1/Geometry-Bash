using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{

    public Slider p1Healthbar;
    public int hpValue = 100;

    // Start is called before the first frame update
    void Awake()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        Debug.Log("ballin");
        //p1Healthbar.value = hpValue;
    }

    public int getHealth(){
        return hpValue;
    }

    public void takeDamage(int damage)
    {
        hpValue -= damage;
        p1Healthbar.value = hpValue;
    }

    public void isHealthZero(){
        if(hpValue == 0)
        {

        }
    }
}
