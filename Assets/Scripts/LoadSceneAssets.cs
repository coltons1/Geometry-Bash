using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSceneAssets : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject p1, p2;
    private GameObject h1, h2;
    [SerializeField] int p1x, p1y, p2x, p2y;

    //sets p1 position to (p1x,p1y) and p2 position to (p2x,p2y)
    public void setPositions()
    {
        //assigns p1 and p2 to player 1 & player 2
        p1 = GameObject.Find("Player 1");
        p2 = GameObject.Find("Player 2");
        
        //sets p1 position and velocity
        p1.transform.position = new Vector2(p1x, p1y);
        p1.GetComponent<Rigidbody2D>().velocity = new Vector2(0.0f,0.0f);
        
        //sets p2 position and velocity
        p2.transform.position = new Vector2(p2x, p2y);
        p2.GetComponent<Rigidbody2D>().velocity = new Vector2(0.0f,0.0f);

        //assigns h1 and h2 to player 1 health bar and player 2 healthbar
        h1 = GameObject.Find("p1Healthbar");
        h2 = GameObject.Find("p2Healthbar");

        //h1.SetActive(true);
        //h2.SetActive(true);

        h1.transform.position = new Vector2(-560, 400);
        h2.transform.position = new Vector2(600, 400);





    }


}
