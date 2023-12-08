using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Animations;

public class AnimationChange : MonoBehaviour
{
    public AnimatorController controller;
    public GameObject player;
    //changes sprite renderer on "player" object to "sprite"
    public void changeAnimation(){
        player.GetComponent<Animator>().runtimeAnimatorController = controller;
    }

}
