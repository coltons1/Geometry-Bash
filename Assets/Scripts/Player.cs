using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    //creation of jumpheight and movespeed
    bool p1Alive;
    bool p2Alive;
    public float jumpHeight;
    public float moveSpeed;

    [SerializeField] GameObject Player1;
    [SerializeField] GameObject Player2;
    private Rigidbody2D p1;
    private Rigidbody2D p2;
    public int MaxHealth = 100;
    public int health;
    public HealthBar Healthbar;


    // Start is called before the first frame update
    void Start()
    {
        //movement 
        p1 = Player1.GetComponent<Rigidbody2D>();
        p2 = Player2.GetComponent<Rigidbody2D>();
        moveSpeed = 10f;
        jumpHeight = 18f;


        //player health
        health = MaxHealth;
        Healthbar.SetMaxHealth(MaxHealth);


        p1Alive = true;
        p2Alive = true;
        
    }

    //When the object starts colliding
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // makes the player take damage ob collsion
        if(collision.gameObject.name == "BottomPlatform")
        {
            takeDamage(10);
            Healthbar.SetHealth(health);
            Debug.Log("p1 took damage");

        }
    }

    //While the object is colliding
    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.name == "BottomPlatform")
        {
        }
    }
    
    //When the object stops colliding
    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.name == "BottomPlatform")
        {
        }
    }

    // Update is called once per frame
    void Update()
    {
        //if players are alive check if they are inbounds
        if(p1Alive){
            outOfBounds(Player1);
            p1Alive = false;
        }
        if(p2Alive){
            outOfBounds(Player2);
            p2Alive = false;
        }
        
        //Player 1 Movement

        //Player Jump
        if(Input.GetKeyDown(KeyCode.W) && p1.velocity.y == 0){
		    p1.velocity = new Vector3(p1.velocity.x, jumpHeight, 0);
		
	    }

        //Player 1 Move Right
	    if(Input.GetKey(KeyCode.D)){
		    if(p1.velocity.y != 0){
                p1.velocity = new Vector3(moveSpeed / 1.5f, p1.velocity.y, 0);
            } 
            else {
                p1.velocity = new Vector3(moveSpeed, p1.velocity.y, 0);
            }
            p1.transform.localScale = new Vector3(-2.5f, 2.5f, 2.5f);
	
	    }

        //Player 1 Move Left
	    if(Input.GetKey(KeyCode.A)){
            if(p1.velocity.y != 0){
                p1.velocity = new Vector3(-moveSpeed / 1.5f, p1.velocity.y, 0);
            } 
            else {
                p1.velocity = new Vector3(-moveSpeed, p1.velocity.y, 0);
            }	
            p1.transform.localScale = new Vector3(2.5f, 2.5f, 2.5f);	
	    }

        //Player 1 Move Down
        if(Input.GetKey(KeyCode.S)){
            p1.velocity = new Vector3(p1.velocity.x, -jumpHeight / 1.25f, 0);
        }


        //Player 2 Movement

        //Player 2 Jump
         if(Input.GetKeyDown(KeyCode.I) && p2.velocity.y == 0){
		    p2.velocity = new Vector3(p2.velocity.x, jumpHeight, 0);
		
	    }

        //Player 2 Move Right
	    if(Input.GetKey(KeyCode.L)){
		    if(p2.velocity.y != 0){
                p2.velocity = new Vector3(moveSpeed / 1.5f, p2.velocity.y, 0);
            } 
            else {
                p2.velocity = new Vector3(moveSpeed, p2.velocity.y, 0);
            }
            p1.transform.localScale = new Vector3(-2.5f, 2.5f, 2.5f);	
	    }

        //Player 2 Move Left
	    if(Input.GetKey(KeyCode.J)){
		    if(p2.velocity.y != 0){
                p2.velocity = new Vector3(-moveSpeed / 1.5f, p2.velocity.y, 0);
            } 
            else {
                p2.velocity = new Vector3(-moveSpeed, p2.velocity.y, 0);
            }
            p1.transform.localScale = new Vector3(2.5f, 2.5f, 2.5f);	
	    }

        //Player 2 Move Down
        if(Input.GetKey(KeyCode.K)){
            p2.velocity = new Vector3(p2.velocity.x, -jumpHeight / 1.25f, 0);
        }
    }
    //finds the player position on the camera and if it has fallen out of bounds
    void outOfBounds(GameObject theGuy){
        if(theGuy.GetComponent<Rigidbody2D>().transform.position.x < -20 ||
        theGuy.GetComponent<Rigidbody2D>().transform.position.x > 20 ||
        theGuy.GetComponent<Rigidbody2D>().transform.position.y < -12 ||
        theGuy.GetComponent<Rigidbody2D>().transform.position.y > 12){
            Destroy(theGuy);
            Debug.Log("Skull Emoji");
        }
    }

    //makes the player take damage
    private void takeDamage(int damage){
        health = health - damage;
        Debug.Log("*Ooh Ouch Yikes Yowch Oof Skeeouch Yeeowch*");
    }
}
