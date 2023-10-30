using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{

    public Slider healthbar;
    public int hpValue = 100;
    //public int hpValueP2 = 100;

    // Start is called before the first frame update
    void Awake()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {

    }

    public int getHealth(){
        return 0;
    }

    public void takeDamage(int damage)
    {
        hpValue -= damage;
        healthbar.value = hpValue;
    }

    public void updateHealthbar(){

    }

   public void isHealthZero(){
        if(hpValue == 0)
        {
            Debug.Log("game over pal");
        }
    }
}
