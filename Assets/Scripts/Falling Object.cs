using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFall : MonoBehaviour
{

    void awake()
    {

    }
 //Detect collisions between the GameObjects with Colliders attached
    public void OnCollisionEnter2D(Collision2D collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.name == "Player 1")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            Debug.Log("");
        }
    }
}
