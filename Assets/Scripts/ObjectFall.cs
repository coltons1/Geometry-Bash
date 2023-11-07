using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFall : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject fallingObj;
    [SerializeField] int posX, posY;
    void Start()
    {
       fallingObj.GetComponent<Rigidbody2D>().isKinematic = true;

    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (fallingObj.GetComponent<Rigidbody2D>().isKinematic == true && collision.gameObject.name == "Player 1" 
            || collision.gameObject.name == "Player 2" )
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            Debug.Log("Enter");
            Invoke("fall", 1);
            Invoke("resetPosition",4);
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.name == "Player 1"|| collision.gameObject.name == "Player 2")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            Debug.Log("Stay");
            
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.name == "Player 1"|| collision.gameObject.name == "Player 2")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            Debug.Log("Exit");
        }
    }

    //makes the object fall by making it a dyaimc object
    private void fall()
    {
        fallingObj.GetComponent<Rigidbody2D>().isKinematic = false;
    }

    // sets the object positions back to a set vale, makes it static, and sets velocities to 0
    private void resetPosition()
    {
        fallingObj.transform.position = new Vector2(posX, posY);    
        fallingObj.GetComponent<Rigidbody2D>().isKinematic = true;
        fallingObj.GetComponent<Rigidbody2D>().velocity = new Vector2(0.0f,0.0f);


    }
}
