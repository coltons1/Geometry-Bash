using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{

    public Slider healthbar;
    public int hpValueP1 = 100;
    public int hpValueP2 = 100;

    // Start is called before the first frame update
    void Awake()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        //a
    }

    public int getHealth(){
        return 0;
    }

    public void takeDamage(int damage)
    {
        //hpValue -= damage;
    }

    public void updateHealthbar(){

    }

   /* public void isHealthZero(){
        if(hpValue == 0)
        {
            Debug.Log("game over pal");
        }
    }*/
}
