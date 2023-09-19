using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubZeroMove : MonoBehaviour
{
    //creation of jumpheight and movespeed

    public float jumpHeight;
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.name = "SubZeroDude";
        moveSpeed = 5;
        jumpHeight = 5;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
		    GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x,jumpHeight);
		
	    }

	    if(Input.GetKey(KeyCode.D)){
		    GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed,GetComponent<Rigidbody2D>().velocity.y);
		
	    }

	    if(Input.GetKey(KeyCode.A)){
		    GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed,GetComponent<Rigidbody2D>().velocity.y);
		
	    }
    }
}
