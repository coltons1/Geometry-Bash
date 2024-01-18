using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Player1 : MonoBehaviour
{
    //creation of jumpheight and movespeed
    bool p1Alive;
    private int num = 0;
    public float jumpHeight;
    public float moveSpeed;
    [SerializeField] GameObject Player;
    [SerializeField] Sprite attackSprite;
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public GameObject rangedAttack;
    public LayerMask enemyLayer;
    private Rigidbody2D p1;
    public int MaxHealth = 100;
    public int health;
    public float bounceForce;
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
        
        rangedAttack = GameObject.Find("Projectile");
        rangedAttack.SetActive(false);
    }

    //When the object starts colliding
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // makes the player take damage ob collsion
        if(collision.gameObject.tag == "Platform")
        {
            //when player 2 touches the ground, sets isJumping to false
            if(collision.gameObject.tag == "Platform")
            {
                p1Animator.SetBool("isJumping", false);
            }
            //takeDamage(10);
            //Healthbar.SetHealth(health); 
            //Healthbar.SetHealth(health);
        }
        if(collision.gameObject.tag == "Trampoline"){
            Debug.Log("trampoline touched");
            Debug.Log(bounceForce);
            p1.velocity = Vector2.up * bounceForce;
            // Debug.Log(p1.velocity);
        }
    }
    private void OnColliisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "BottomPlatform")
        {
            takeDamage(5);
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

        //assigns speed and airspeed variables to velocity
        p1Animator.SetFloat("Speed", Mathf.Abs(p1.velocity.x));
        p1Animator.SetFloat("AirSpeed", Mathf.Abs(p1.velocity.y));

        //assings isAttacking variable initially to false
        p1Animator.SetBool("isMelee", false);
        
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
            p1Animator.SetBool("isMelee", true);
            meleeAttack();
        }
        //Player 1 attack
        if(Input.GetKeyUp(KeyCode.Q)){
            attackRanged();
        }

    }
    //finds the player position on the camera and if it has fallen out of bounds and changes to victory screen
    private void outOfBounds(){
        if(p1.transform.position.x < -20 ||
        p1.transform.position.x > 20 ||
        p1.transform.position.y < -12 ||
        p1.transform.position.y > 12){
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
            enemy.GetComponent<Player2>().takeDamage(10);
        }
        Debug.Log("attacked");

        p1Animator.SetBool("attack", true);
        /*if (this.animator.GetCurrentAnimatorStateInfo(0).IsName("YourAnimationName"))
        {
            
        }*/

    }
    //Destroys Melee

    //does a basic melee attack
    private void attackRanged(){
        rangedAttack.SetActive(true);
        Collider2D[] hitEnemys = Physics2D.OverlapCircleAll(rangedAttack.transform.position, attackRange, enemyLayer);
        Invoke("removeRangedAttack",5);
        foreach(Collider2D enemy in hitEnemys){
            Debug.Log("hit");
            enemy.GetComponent<Player2>().takeDamage(10);
            num++;
        }
    }

    public void youLose(){
        Destroy(Player);
        p1Alive = false;
        SceneManager.LoadScene("Victory Screen");
        //Destroy("DontDestroyOnLoad");
        Debug.Log("Player 2 wins");
        GameObject.Find("Healthbars").SetActive(false);
        GameObject.Find("Player 2").SetActive(false);

    }
    
    private void OnDrawGizmosSelected(){
        if(attackPoint == null || rangedAttack == null){
            return;
        }

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
        Gizmos.DrawWireSphere(rangedAttack.transform.position, attackRange);

    }

    private void removeRangedAttack(){
        rangedAttack.SetActive(false);
    }
}
