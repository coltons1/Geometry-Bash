using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile1 : MonoBehaviour
{
public GameObject bullet;
public Rigidbody2D bulletBody;
public LayerMask enemyLayer;
private GameObject player;
private string direction;

    void Start()
    {
        bulletBody = bullet.GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player 1");
        Invoke("removeRangedAttack", 2);
        direction = player.GetComponent<Player1>().getDirection();
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
            enemy.GetComponent<Player2>().takeDamage(5);
            Rigidbody2D p2 = GameObject.Find("Player 2").GetComponent<Rigidbody2D>();

            if(direction == "right"){
                p2.velocity = new Vector3(p2.velocity.x + 5.0f, p2.velocity.y + 3.0f);
            }
            else{
                p2.velocity = new Vector3(p2.velocity.x -5.0f, p2.velocity.y + 3.0f);
            }
            Destroy(this.gameObject);
        }
    }
    private void removeRangedAttack(){
        Destroy(GameObject.Find("ProjectileOne(Clone)"));
    }
}
