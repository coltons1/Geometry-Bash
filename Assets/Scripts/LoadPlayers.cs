using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadPlayers : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject p1, p2;
    public void setPositions()
    {
        p1.transform.position = new Vector2(-10.0f, 0.0f);
        p1.GetComponent<Rigidbody2D>().velocity = new Vector2(0.0f,0.0f);
        p2.transform.position = new Vector2(10.0f, 0.0f);
        p2.GetComponent<Rigidbody2D>().velocity = new Vector2(0.0f,0.0f);


    }


}
