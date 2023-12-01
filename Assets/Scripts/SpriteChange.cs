using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChange : MonoBehaviour
{
    public Sprite sprite;
    public GameObject player;
    //changes sprite renderer on "player" object to "sprite"



    public void changeSprite(){
            player.GetComponent<SpriteRenderer>().sprite = sprite;
    }

    public void changeSprite(Sprite s){
            this.gameObject.GetComponent<SpriteRenderer>().sprite = sprite;
    }

}
