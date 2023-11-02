using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Player : MonoBehaviour
{
    //creation of jumpheight and movespeed
    HealthController health1;
    HealthController health2;
    public float jumpHeight;
    public float moveSpeed;

    [SerializeField] GameObject Player1;
    [SerializeField] GameObject Player2;
    private Rigidbody2D p1;
    private Rigidbody2D p2;

    void Awake()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if(sceneName == "Stage1")
        {
            health1 = GameObject.Find("p1Healthbar").GetComponent<HealthController>();
            health2 = GameObject.Find("p2Healthbar").GetComponent<HealthController>();
        }
        
    }
    // Start is called before the first frame update
    void Start()
    {
        //movement 
        p1 = Player1.GetComponent<Rigidbody2D>();
        p2 = Player2.GetComponent<Rigidbody2D>();
        moveSpeed = 10f;
        jumpHeight = 18f;
        
    }

    //When the object starts colliding
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "BottomPlatform")
        {
            Debug.Log("enter");
            health1.takeDamage(5);
        }
    }

    //While the object is colliding
    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.name == "BottomPlatform")
        {
            Debug.Log("stay");
        }
    }
    
    //When the object stops colliding
    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.name == "BottomPlatform")
        {
            Debug.Log("exit");    
        }
    }

    // Update is called once per frame
    void Update()
    {
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
	
	    }

        //Player 1 Move Left
	    if(Input.GetKey(KeyCode.A)){
            if(p1.velocity.y != 0){
                p1.velocity = new Vector3(-moveSpeed / 1.5f, p1.velocity.y, 0);
            } 
            else {
                p1.velocity = new Vector3(-moveSpeed, p1.velocity.y, 0);
            }		
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
	    }

        //Player 2 Move Left
	    if(Input.GetKey(KeyCode.J)){
		    if(p2.velocity.y != 0){
                p2.velocity = new Vector3(-moveSpeed / 1.5f, p2.velocity.y, 0);
            } 
            else {
                p2.velocity = new Vector3(-moveSpeed, p2.velocity.y, 0);
            }
	    }

        //Player 2 Move Down
        if(Input.GetKey(KeyCode.K)){
            p2.velocity = new Vector3(p2.velocity.x, -jumpHeight / 1.25f, 0);
        }

    }
}
