using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apocalypse : MonoBehaviour
{
    GameObject p1, p2, h1, h2, h;
    
    // Start is called before the first frame update
    void Start()
    {
        p1 = GameObject.Find("Player 1");
        p2 = GameObject.Find("Player 2");
        h = GameObject.Find("Healthbars");
        h1 = GameObject.Find("P1HealthBar");
        h2 = GameObject.Find("P2HealthBar");
    }

    public void ApocalypseGo(){
        Destroy(p1);
        Destroy(p2);
        Destroy(h1);
        Destroy(h2);
        Destroy(h);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
