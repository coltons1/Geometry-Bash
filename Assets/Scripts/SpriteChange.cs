using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChange : MonoBehaviour
{
    public Sprite sprite;
    public GameObject player;
    public void changeSprite(){
            player.GetComponent<SpriteRenderer>().sprite = sprite;
    }

}
