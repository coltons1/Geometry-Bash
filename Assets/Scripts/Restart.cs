using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{

    private GameObject p1, p2;
    private GameObject h;
    // Start is called before the first frame update
    public void Reset()
    {
        p1 = GameObject.Find("Player 1");
        p2 = GameObject.Find("Player 2");
        h = GameObject.Find("Healthbars");

        /*if(p1.activeSelf == true){
            p2.SetActive(true);
        } else if(p2.activeSelf == true){
            p1.SetActive(true);
        }

        h1 = GameObject.Find("P1HealthBar");
        h2 = GameObject.Find("P2HealthBar");*/

        Destroy(p1);
        Destroy(p2);
        Destroy(h);


    }

    // Update is called once per frame
}
