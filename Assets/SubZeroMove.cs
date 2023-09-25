using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubZeroMove : MonoBehaviour
{
    //code from johnz1234 off of the unity discussions boards
    //https://discussions.unity.com/t/how-to-move-a-2d-sprite/139655

    //creation of jumpheight and movespeed

    public float jumpHeight;
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 10;
        jumpHeight = 15;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W)){
		    GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x,jumpHeight);
		
	    }

	    if(Input.GetKey(KeyCode.D)){
		    GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed,GetComponent<Rigidbody2D>().velocity.y);
		
	    }

	    if(Input.GetKey(KeyCode.A)){
		    GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed,GetComponent<Rigidbody2D>().velocity.y);
		
	    }

        if(Input.GetKey(KeyCode.S)){
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x,-jumpHeight);
        }
    }
}
