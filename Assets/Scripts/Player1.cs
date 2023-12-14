using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Player1 : MonoBehaviour
{
    //creation of jumpheight and movespeed
    bool p1Alive;
    public float jumpHeight;
    public float moveSpeed;
    [SerializeField] GameObject Player;
    [SerializeField] Sprite attackSprite;
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayer;
    private Rigidbody2D p1;
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
        Debug.Log("p1: method runs");
        // makes the player take damage ob collsion
        if(collision.gameObject.tag == "Platform")
        {
            Debug.Log("p1: first if runs");
            //when player 2 touches the ground, sets isJumping to false
            if(collision.gameObject.tag == "Platform")
            {
                p1Animator.SetBool("isJumping", false);
                Debug.Log("p1: second if runs");
            }
            //takeDamage(10);
            //Healthbar.SetHealth(health);
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
        if(p1Alive){
            outOfBounds();
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
    //finds the player position on the camera and if it has fallen out of bounds and changes to victory screen
    private void outOfBounds(){
        if(p1.transform.position.x < -20 ||
        p1.transform.position.x > 20 ||
        p1.transform.position.y < -12 ||
        p1.transform.position.y > 12){
            Destroy(Player);
            p1Alive = false;
            Debug.Log("Skull Emoji");
            SceneManager.LoadScene("Victory Screen");
            Debug.Log("p1 more like pwon");
        }
    }

    //makes the player take damage
    public void takeDamage(int damage){
        health = health - damage;
        Healthbar.SetHealth(health);

        Debug.Log("*Ooh Ouch Yikes Yowch Oof Skeeouch Yeeowch*");
    }

    //does a basic melee attack
    private void meleeAttack(){
        Collider2D[] hitEnemys = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayer);

        foreach(Collider2D enemy in hitEnemys){
            Debug.Log("hit");
            enemy.GetComponent<Player2>().takeDamage(10);
        }

    }
    //Destroys Melee

    private void OnDrawGizmosSelected(){
        if(attackPoint == null){
            return;
        }

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);

    }
}
