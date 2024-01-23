using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
public GameObject bullet;
public Rigidbody2D bulletBody;
public LayerMask enemyLayer;

    void Start()
    {
        bulletBody = bullet.GetComponent<Rigidbody2D>();
        Invoke("removeRangedAttack", 2);

    }

    // Update is called once per frame
    void Update()
    {
       bulletBody.velocity = new Vector3(10f, 0f, 0f);
        Collider2D[] hitEnemys = Physics2D.OverlapCircleAll(GameObject.Find("Projectile(Clone)").transform.position, 0.5f, enemyLayer);
        foreach(Collider2D enemy in hitEnemys){
            Debug.Log("hit");
            enemy.GetComponent<Player2>().takeDamage(10);
            Destroy(GameObject.Find("Projectile(Clone)"));
        }
    }
    private void removeRangedAttack(){
        Destroy(GameObject.Find("Projectile(Clone)"));
    }
}
