using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChange : MonoBehaviour
{
    public Sprite sprite;
    public GameObject p1, p2;
    public void changeSprite(){
            p1.GetComponent<SpriteRenderer>().sprite = sprite;
    }

}
