using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //creation of jumpheight and movespeed

    public float jumpHeight;
    public float moveSpeed;

    [SerializeField] GameObject Player1;
    [SerializeField] GameObject Player2;
    private Rigidbody2D p1;
    private Rigidbody2D p2;

    // Start is called before the first frame update
    void Start()
    {
        p1 = Player1.GetComponent<Rigidbody2D>();
        p2 = Player2.GetComponent<Rigidbody2D>();
        moveSpeed = 10f;
        jumpHeight = 18f;
        
    }

    // Update is called once per frame
    void Update()
    {
        //Player 1 Movement
        if(Input.GetKeyDown(KeyCode.W) && p1.velocity.y == 0){
		    p1.velocity = new Vector3(p1.velocity.x, jumpHeight, 0);
		
	    }

	    if(Input.GetKey(KeyCode.D)){
		    if(p1.velocity.y != 0){
                p1.velocity = new Vector3(moveSpeed / 1.5f, p1.velocity.y, 0);
            } 
            else {
                p1.velocity = new Vector3(moveSpeed, p1.velocity.y, 0);
            }
	
	    }

	    if(Input.GetKey(KeyCode.A)){
            if(p1.velocity.y != 0){
                p1.velocity = new Vector3(-moveSpeed / 1.5f, p1.velocity.y, 0);
            } 
            else {
                p1.velocity = new Vector3(-moveSpeed, p1.velocity.y, 0);
            }		
	    }

        if(Input.GetKey(KeyCode.S)){
            p1.velocity = new Vector3(p1.velocity.x, -jumpHeight / 1.25f, 0);
        }


        //Player 2 Movement
         if(Input.GetKeyDown(KeyCode.I) && p2.velocity.y == 0){
		    p2.velocity = new Vector3(p2.velocity.x, jumpHeight, 0);
		
	    }

	    if(Input.GetKey(KeyCode.L)){
		    if(p2.velocity.y != 0){
                p2.velocity = new Vector3(moveSpeed / 1.5f, p2.velocity.y, 0);
            } 
            else {
                p2.velocity = new Vector3(moveSpeed, p2.velocity.y, 0);
            }
	    }

	    if(Input.GetKey(KeyCode.J)){
		    if(p2.velocity.y != 0){
                p2.velocity = new Vector3(-moveSpeed / 1.5f, p2.velocity.y, 0);
            } 
            else {
                p2.velocity = new Vector3(-moveSpeed, p2.velocity.y, 0);
            }
	    }

        if(Input.GetKey(KeyCode.K)){
            p2.velocity = new Vector3(p2.velocity.x, -jumpHeight / 1.25f, 0);
        }

    }
}
