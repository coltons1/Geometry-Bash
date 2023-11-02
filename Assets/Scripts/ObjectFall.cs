using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.name == "Player 1")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            Debug.Log("Enter");
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.name == "Player 1")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            Debug.Log("Stay");
        }
    }
        private void OnCollisionExit2D(Collision2D collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.name == "Player 1")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            Debug.Log("Exit");
        }
    }
}
