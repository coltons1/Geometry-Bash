using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationChange : MonoBehaviour
{
    public Animator controller;
    public GameObject player;
    //changes sprite renderer on "player" object to "sprite"
    public void changeAnimation(){
            //player.GetComponent<Animator>().controller = controller;
    }

}
