using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChange : MonoBehaviour
{
    public Sprite red, blue;
    public void Update(){
        GetComponent<SpriteRenderer>().sprite = red;
    }

}
