using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedGuyMove : MonoBehaviour
{

    //code from johnz1234 off of the unity discussions boards
    //https://discussions.unity.com/t/how-to-move-a-2d-sprite/139655

    public float jumpHeight;
    public float moveSpeed;
    private Rigidbody2D redGuy;
    //public BoxCollider2D coll;
    //public float dynFriction;
    //public float statFriction;
    // Start is called before the first frame update
    void Start()
    {
        redGuy = GetComponent<Rigidbody2D>();
        moveSpeed = 10f;
        jumpHeight = 18f;

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I) && redGuy.velocity.y == 0){
		    redGuy.velocity = new Vector3(redGuy.velocity.x, jumpHeight, 0);

		
	    }

	    if(Input.GetKey(KeyCode.L)){
		    redGuy.velocity = new Vector3(moveSpeed, redGuy.velocity.y, 0);
		
	    }

	    if(Input.GetKey(KeyCode.J)){
		    redGuy.velocity = new Vector3(-moveSpeed, redGuy.velocity.y, 0);
		
	    }

        if(Input.GetKey(KeyCode.K)){
            redGuy.velocity = new Vector3(redGuy.velocity.x, -jumpHeight, 0);
        }
    }
}
