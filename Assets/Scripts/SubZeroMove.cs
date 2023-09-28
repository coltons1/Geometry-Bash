using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubZeroMove : MonoBehaviour
{

    //creation of jumpheight and movespeed

    public float jumpHeight;
    public float moveSpeed;
    private Rigidbody2D subZero;

    // Start is called before the first frame update
    void Start()
    {
        subZero = GetComponent<Rigidbody2D>();
        moveSpeed = 10;
        jumpHeight = 15;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W) && subZero.velocity.y == 0){
		    subZero.velocity = new Vector3(subZero.velocity.x, jumpHeight, 0);
		
	    }

	    if(Input.GetKey(KeyCode.D)){
		    subZero.velocity = new Vector3(moveSpeed, subZero.velocity.y, 0);
	
	    }

	    if(Input.GetKey(KeyCode.A)){
            subZero.velocity = new Vector3(-moveSpeed, subZero.velocity.y, 0);		
	    }

        if(Input.GetKey(KeyCode.S)){
            subZero.velocity = new Vector3(subZero.velocity.x, -jumpHeight, 0);
        }
    }
}
