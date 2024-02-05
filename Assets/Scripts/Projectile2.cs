using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile2 : MonoBehaviour
{
public GameObject bullet;
public Rigidbody2D bulletBody;
public LayerMask enemyLayer;
public GameObject player;

    void Start()
    {
        bulletBody = bullet.GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player 2");
        Invoke("removeRangedAttack", 2);
        string direction = player.GetComponent<Player2>().getDirection();
        if(direction == "right"){
            bulletBody.velocity = new Vector3(15f, 0f, 0f);
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
            enemy.GetComponent<Player1>().takeDamage(10);
            Destroy(this.gameObject);
        }
    }
    private void removeRangedAttack(){
        Destroy(GameObject.Find("ProjectileTwo(Clone)"));
    }
}
