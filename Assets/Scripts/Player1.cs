using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Player1 : MonoBehaviour
{
    //creation of jumpheight and movespeed
    bool p1Alive;
    //private int num = 0;
    public float jumpHeight;
    public float moveSpeed;
    [SerializeField] GameObject Player;
    [SerializeField] Sprite attackSprite;
    public Transform attackPoint;
    public float attackRange = 1.25f;
    public GameObject rangedAttack;
    public LayerMask enemyLayer;
    private Rigidbody2D p1;
    public int MaxHealth = 100;
    public int health;
    public float bounceForce;
    public HealthBar Healthbar;
    public Animator p1Animator;
    public string direction = "right";
    public bool isMeleeAttacking;
    public string character;
    public  int attackPower = 10;
    public float knockback = 8f;
    public float attackSpeed = 0;
    public bool grounded;
    public Vector2 boxSize;
    public float castDistance;
    public LayerMask groundLayer;
    
    public Pause pause;


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

        rangedAttack.transform.position = attackPoint.position;

        //direction = "right";

        isMeleeAttacking = false;
        grounded = true;
        
    }

    //When the object starts colliding
    private void OnCollisionEnter2D(Collision2D collision)
    {
            //when player 2 touches the ground, sets isJumping to false
        if(collision.gameObject.tag == "Platform")
        {
            p1Animator.SetBool("isJumping", false);
            grounded = true;
        }
            //takeDamage(10);
            //Healthbar.SetHealth(health); 
        if(collision.gameObject.tag == "Trampoline"){
            Debug.Log("trampoline touched");
            p1.velocity = Vector2.up * bounceForce;
            // Debug.Log(p1.velocity);
        }
    }

    //While the object is colliding
    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Platform"){
            grounded = true;
        }
    }
    
    //When the object stops colliding
    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Platform"){
            grounded = false;
        }
    }

    // public bool isGrounded(){
    //     if(Physics2D.BoxCast(transform.position, boxSize, 0, -transform.up, castDistance, groundLayer)){
    //         return true;
    //     }
    //     else {
    //         return false;
    //     }
    // }

    // private void OnDrawGizmos(){
    //     Gizmos.DrawWireCube(transform.position-transform.up * castDistance, boxSize);
    // }

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
        
        //Player 1 Movement

        //Player Jump
        //do the isGrounded method ig
        if(Input.GetKeyDown(KeyCode.W) && /*p1.velocity.y == 0*/ grounded == true){
	        p1.velocity = new Vector3(p1.velocity.x, jumpHeight, 0);
            p1Animator.SetBool("isJumping", true);   
            grounded = false;         
	    }
        

        //Player 1 Move Right
	    if(Input.GetKey(KeyCode.D)){
		    if(p1.velocity.y != 0){
                p1.velocity = new Vector3(moveSpeed / 1.5f, p1.velocity.y, 0);
            } 
            else {
                p1.velocity = new Vector3(moveSpeed, p1.velocity.y, 0);
            }
            direction = "right";
	
	    }
        if(direction == "right"){
            if(p1.GetComponent<Player1>().getCharacter() == "Hero" || p1.GetComponent<Player1>().getCharacter() == "Warrior" || p1.GetComponent<Player1>().getCharacter() == "Knight"){
                p1.transform.localScale = new Vector3(2.5f, 2.5f, 2.5f);
                //get out of my code	
            }
            else if(p1.GetComponent<Player1>().getCharacter() == "Bandit" ){
                p1.transform.localScale = new Vector3(-2.5f, 2.5f, 2.5f);	
            }
        }

        //Player 1 Move Left
	    if(Input.GetKey(KeyCode.A)){
            if(p1.velocity.y != 0){

                p1.velocity = new Vector3(-moveSpeed / 1.5f, p1.velocity.y, 0);
            } 
            else {
                p1.velocity = new Vector3(-moveSpeed, p1.velocity.y, 0);
            }	
            direction = "left";
	    }
        if(direction == "left"){
            if(p1.GetComponent<Player1>().getCharacter() == "Hero" || p1.GetComponent<Player1>().getCharacter() == "Warrior" || p1.GetComponent<Player1>().getCharacter() == "Knight"){
                p1.transform.localScale = new Vector3(-2.5f, 2.5f, 2.5f);	
            }
            else if(p1.GetComponent<Player1>().getCharacter() == "Bandit"){
                p1.transform.localScale = new Vector3(2.5f, 2.5f, 2.5f);	
            }

        }

        //Player 1 Move Down
        if(Input.GetKey(KeyCode.S)){
            p1.velocity = new Vector3(p1.velocity.x, -jumpHeight / 1.25f, 0);
        }

        //Player 1 attack
        if(Input.GetKeyDown(KeyCode.E)){
            if(Player.GetComponent<AttackTimer>() == null && Player.GetComponent<DelayTimer>() == null){
                p1Animator.SetBool("isMelee", true);
                Invoke("setIsMeleeFalse", 0.1f);
                if(Player.GetComponent<DelayTimer>() == null){
                    Player.AddComponent<DelayTimer>();
                    Player.GetComponent<DelayTimer>().setTimer(0.2f);

                }
            }
        }
        //Player 1 attack
        if(Input.GetKeyUp(KeyCode.Q)){
            if(Player.GetComponent<AttackTimer>() == null){
                p1Animator.SetBool("isMelee", true);
                Invoke("setIsMeleeFalse", 0.05f);
                attackRanged();
                Player.AddComponent<AttackTimer>();
                Player.GetComponent<AttackTimer>().setTimer(0.5f);
            }
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
    public void meleeAttack(){
        isMeleeAttacking = true;
        p1.GetComponent<AudioSource>().Play();

        Collider2D[] hitEnemys = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayer);

        foreach(Collider2D enemy in hitEnemys){

            if(GameObject.Find("Player 2").GetComponent<Rigidbody2D>() != null){
                Rigidbody2D p2 = GameObject.Find("Player 2").GetComponent<Rigidbody2D>();
                if(Player.GetComponent<Player1>().getDirection() == "right"){
                    p2.velocity = new Vector3(p2.velocity.x + knockback, p2.velocity.y + 5.0f);
                }
                else{
                    p2.velocity = new Vector3(p2.velocity.x - knockback, p2.velocity.y + 5, 0f);
                }
                enemy.GetComponent<Player2>().takeDamage(attackPower);
            }
        }
        Debug.Log("p1 attacked");
        if(Player.GetComponent<AttackTimer>() == null){
            Player.AddComponent<AttackTimer>();
            Player.GetComponent<AttackTimer>().setTimer(0.2f);
        }

        /*if (this.animator.GetCurrentAnimatorStateInfo(0).IsName("YourAnimationName"))
        {
            
        }*/

    }

    //does a basic melee attack
    private void attackRanged(){
        Instantiate(rangedAttack,attackPoint.position, Quaternion.Euler(0f,0f,0f));
    }

    public void youLose(){
        Destroy(Player);
        //GameObject.Find("P1HealthBar").SetActive(false);
        p1Alive = false;
        
        Destroy(GameObject.Find("Healthbars"));
        
        SceneManager.LoadScene("WinSceneP2");

        Debug.Log("Player 2 wins");
    }
    
    private void OnDrawGizmosSelected(){
        if(attackPoint == null || rangedAttack == null){
            return;
        }

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
        Gizmos.DrawWireSphere(rangedAttack.transform.position, attackRange);

    }

    public string getDirection(){
        return direction;
    }

    public void setCharacter(string name){
        character= name; 
    }

    public string getCharacter(){
        return character;
    }

    public void setAttackRange(float range){
        attackRange = range;
    }

    private void setIsMeleeFalse(){
        p1Animator.SetBool("isMelee", false);
    }
    public void setAttackPower(int power){
        attackPower = power;
    }

    public void setMoveSpeed(float s){
        moveSpeed = s;
    }
    public void setAttackSpeed(float aS){
        attackSpeed = aS;
    }
    public void setKnockBack(float power){
        knockback = power;
    }

    public void setDirection(string dir){
        direction = dir;
    }
}
