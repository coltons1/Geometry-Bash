using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Player2 : MonoBehaviour
{
    //creation of jumpheight and movespeed
    bool p2Alive;
    public float jumpHeight;
    public float moveSpeed;
    [SerializeField] GameObject Player;
    [SerializeField] Sprite attackSprite;
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayer;
    private Rigidbody2D p2;
    public int MaxHealth = 100;
    public int health;
    public float bounceForce;
    public HealthBar Healthbar;
    public Animator p1Animator;
    public Animator p2Animator;


    // Start is called before the first frame update
    void Start()
    {

        //intializes melee

        //movement 
        p2 = Player.GetComponent<Rigidbody2D>();
        moveSpeed = 10f;
        jumpHeight = 18f;


        //player health
        health = MaxHealth;
        Healthbar.SetMaxHealth(MaxHealth);


        p2Alive = true;
        
        p2Animator = Player.GetComponent<Animator>();
        
    }

    //When the object starts colliding
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("p2: method runs");
        // makes the player take damage ob collsion
        if(collision.gameObject.tag == "Platform")
        {
            Debug.Log("p2: first if runs");
            //when player 2 touches the ground, sets isJumping to false
            if(collision.gameObject.tag == "Platform")
            {
                Debug.Log("p2: second if runs");
                p2Animator.SetBool("isJumping", false);
            }
            //takeDamage(10);
            //Healthbar.SetHealth(health);
        }
    }

    private void OnColliisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "BottomPlatform")
        {
            takeDamage(5);
        }
        
        if(collision.gameObject.CompareTag("Trampoline")){
            p2.velocity = Vector2.up * bounceForce;
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
        if(p2Alive){
            outOfBounds();
        }
       

        //assigns speed and airspeed variables to velocitys
        p2Animator.SetFloat("Speed", Mathf.Abs(p2.velocity.x));
        p2Animator.SetFloat("AirSpeed", Mathf.Abs(p2.velocity.y));
        


        //Player 2 Movement

        //Player 2 Jump
         if(Input.GetKeyDown(KeyCode.I) && p2.velocity.y == 0){
		    p2.velocity = new Vector3(p2.velocity.x, jumpHeight, 0);
            p2Animator.SetBool("isJumping", true);
	    }

        //Player 2 Move Right
	    if(Input.GetKey(KeyCode.L)){
		    if(p2.velocity.y != 0){
                p2.velocity = new Vector3(moveSpeed / 1.5f, p2.velocity.y, 0);
            } 
            else {
                p2.velocity = new Vector3(moveSpeed, p2.velocity.y, 0);
            }
            p2.transform.localScale = new Vector3(2.5f, 2.5f, 2.5f);	
	    }

        //Player 2 Move Left
	    if(Input.GetKey(KeyCode.J)){
		    if(p2.velocity.y != 0){
                p2.velocity = new Vector3(-moveSpeed / 1.5f, p2.velocity.y, 0);
            } 
            else {
                p2.velocity = new Vector3(-moveSpeed, p2.velocity.y, 0);
            }
            p2.transform.localScale = new Vector3(-2.5f, 2.5f, 2.5f);	
	    }

        //Player 2 Move Down
        if(Input.GetKey(KeyCode.K)){
            p2.velocity = new Vector3(p2.velocity.x, -jumpHeight / 1.25f, 0);
        }

        //Player 2 attack
        if(Input.GetKeyUp(KeyCode.U)){
            meleeAttack();
        }
    }

    //finds the player position on the camera and if it has fallen out of bounds
    private void outOfBounds(){
        if(p2.transform.position.x < -20 ||
        p2.transform.position.x > 20 ||
        p2.transform.position.y < -12 ||
        p2.transform.position.y > 12){
            youLose();
        }
    }

    //makes the player take damage
    public void takeDamage(int damage){
        health = health - damage;
        Healthbar.SetHealth(health);
        if(health <= 0){
            youLose();
        }

        Debug.Log("*Ooh Ouch Yikes Yowch Oof Skeeouch Yeeowch*");
    }

    //does a basic melee attack
    private void meleeAttack(){
        Collider2D[] hitEnemys = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayer);

        foreach(Collider2D enemy in hitEnemys){
            Debug.Log("hit");
            enemy.GetComponent<Player1>().takeDamage(10);
        }
    }

    private void OnDrawGizmosSelected(){
        if(attackPoint == null){
            return;
        }

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);

    }
    //Destroys Melee

    
    public void OnLanding(Animator animator){
        animator.SetBool("isJumping", false);
    }

    public void youLose(){
        Destroy(Player);
        Destroy(Healthbar);
    
        p2Alive = false;
        SceneManager.LoadScene("Victory Screen");
        Debug.Log("Player 1 wins");
        GameObject.Find("Healthbars").SetActive(false);
        GameObject.Find("Player 1").SetActive(false);

    }
}

