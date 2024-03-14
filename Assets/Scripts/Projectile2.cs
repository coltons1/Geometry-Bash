using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile2 : MonoBehaviour
{
public GameObject bullet;
public Rigidbody2D bulletBody;
public LayerMask enemyLayer;
public LayerMask nonEnemyLayer;
public GameObject player;
private string direction;

    void Start()
    {
        bulletBody = bullet.GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player 2");
        Invoke("removeRangedAttack", 2);
        direction = player.GetComponent<Player2>().getDirection();
        if(direction == "right"){
            bulletBody.velocity = new Vector3(15f, 0f, 0f);
            bullet.transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        }
        else{
            bulletBody.velocity = new Vector3(-15f, 0f, 0f);
        }


    }

    // Update is called once per frame
    void Update()
    {
        Collider2D[] hitEnemys = Physics2D.OverlapCircleAll(this.gameObject.transform.position, 0.5f, enemyLayer);
        foreach(Collider2D enemy in hitEnemys){
            Debug.Log("hit");
            enemy.GetComponent<Player1>().takeDamage(5);
            Rigidbody2D p1 = GameObject.Find("Player 1").GetComponent<Rigidbody2D>();
            if(direction == "right"){
                p1.velocity = new Vector3(p1.velocity.x + 5.0f, p1.velocity.y + 3.0f);
            }
            else{
                p1.velocity = new Vector3(p1.velocity.x -5.0f, p1.velocity.y + 3.0f);
            }
            Destroy(this.gameObject);
        }
        
        Collider2D[] hitNonEnemys = Physics2D.OverlapCircleAll(this.gameObject.transform.position, 0.5f, nonEnemyLayer);
        foreach(Collider2D nonEnemy in hitNonEnemys){
            Debug.Log("hit");
            Destroy(this.gameObject);
        }
    }
    private void removeRangedAttack(){
        Destroy(GameObject.Find("ProjectileTwo(Clone)"));
    }
}
