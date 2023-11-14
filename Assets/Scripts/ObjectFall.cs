using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFall : MonoBehaviour
{
    private GameObject fallingObj;
    private float posX, posY;

    void Start()
    {
        gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
        //sets reset position to intial posiion
        posX = gameObject.transform.position.x;
        posY = gameObject.transform.position.y;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (gameObject.GetComponent<Rigidbody2D>().isKinematic == true && collision.gameObject.name == "Player 1" 
            || collision.gameObject.name == "Player 2" )
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            Invoke("fall", 1);
            Invoke("resetPosition",4);
        }
    }

    //makes the object fall by making it a dyaimc object
    private void fall()
    {
        gameObject.GetComponent<Rigidbody2D>().isKinematic = false;
    }

    //sets the object positions back to the intial positon, makes it static, and sets velocities to 0
    private void resetPosition()
    {
        gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0.0f,0.0f);
        gameObject.transform.position = new Vector2(posX, posY);    



    }
}
