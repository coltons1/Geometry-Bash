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

    public void takeDamage(int damage)
    {
        this.hpValue -= damage;
        healthbar.value = hpValue;
    }

    public void healDamage(int heal){
        hpValue += heal;
        healthbar.value = hpValue;
    }

   public void isHealthZero(){
        if(hpValue == 0)
        {
            Debug.Log("game over pal");
        }
    }

    /*public void Die(){
        Destroy(GameObject);
    }*/
}
