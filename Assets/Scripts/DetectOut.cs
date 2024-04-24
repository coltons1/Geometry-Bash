using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectOut : MonoBehaviour
{

    GameObject Player1;
    GameObject Player2;

    // Update is called once per frame
    void Update()
    {
        //if(collision.GameObject.tag == "PlayerOne")
    }

    public void OnTriggerExit2D(Collider2D other){
        if(other.CompareTag("PlayerOne")){
            Destroy(Player1);
        }
    }
}
