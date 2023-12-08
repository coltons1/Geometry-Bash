using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Player1 : MonoBehaviour
{
    //creation of jumpheight and movespeed
    bool p1Alive;
    bool p2Alive;
    public float jumpHeight;
    public float moveSpeed;

    [SerializeField] GameObject Player;
    [SerializeField] Sprite attackSprite;
    private Rigidbody2D p1;
    private GameObject MeleeAttack;
    public int MaxHealth = 100;
    public int health;
    public HealthBar Healthbar;
    public Animator p1Animator;


    // Start is called before the first frame update
    void Start()
    {

        //movement 
        p1 = Player.GetComponent<Rigidbody2D>();
        moveSpeed = 10f;
        jumpHeight = 18f;


        //player health
        health = MaxHealth;
        Healthbar.SetMaxHealth(MaxHealth);


        p1Alive = true;
        
        p1Animator = Player.GetComponent<Animator>();
        
    }

    //When the object starts colliding
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // makes the player take damage ob collsion
        if(collision.gameObject.name == "BottomPlatform")
        {
            //when player 1 touches the ground, sets isJumping to false

            if(collision.gameObject.tag == "PlayerOne")
            {
                p1Animator.SetBool("isJumping", false);
                Debug.Log("it worked");
            }
            

            //takeDamage(10);
            //Healthbar.SetHealth(health);
            

        }
        if(collision.gameObject.name == "MeleeAttack"){
            takeDamage(10);
            Healthbar.SetHealth(health);
            Debug.Log("p1 took damage");
        }
    }

    //While the object is colliding
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.name == "BottomPlatform")
        {
        }
    }
    
    //When the object stops colliding
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.name == "BottomPlatform")
        {

        }
    }

    // Update is called once per frame
    void Update()
    {
        //if players are alive check if they are inbounds
        if(p1 != null){
            outOfBounds(Player);
        }
       


        //assigns speed and airspeed variables to velocitys
        p1Animator.SetFloat("Speed", Mathf.Abs(p1.velocity.x));
        p1Animator.SetFloat("AirSpeed", Mathf.Abs(p1.velocity.y));
        
        //Player 1 Movement

        //Player Jump
        if(Input.GetKeyDown(KeyCode.W) && p1.velocity.y == 0){
		    p1.velocity = new Vector3(p1.velocity.x, jumpHeight, 0);
            p1Animator.SetBool("isJumping", true);
		
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

        //Player 1 attack
        if(Input.GetKeyUp(KeyCode.E)){
            meleeAttack();
        }





    }
    //finds the player position on the camera and if it has fallen out of bounds
    private void outOfBounds(GameObject theGuy){
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

    //does a basic melee attack
    private void meleeAttack(){
        GameObject Melee = GameObject.Find("AttackArea");
        Melee.gameObject.AddComponent<SpriteRenderer>();
        Melee.gameObject.GetComponent<SpriteRenderer>().sprite = attackSprite;


    }

    //Destroys Melee
    private void destroyMelee(){
        Destroy(MeleeAttack);
    }

    
    public void OnLanding(Animator animator){
        animator.SetBool("isJumping", false);
    }
}
