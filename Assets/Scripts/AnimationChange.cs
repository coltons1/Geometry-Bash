using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Animations;

public class AnimationChange : MonoBehaviour
{
    public AnimatorController controller;
    public GameObject player;
    public string character;
    //changes sprite renderer on "player" object to "sprite"
    public void changeAnimation(){
        player.GetComponent<Animator>().runtimeAnimatorController = controller;
        if(player == GameObject.Find("Player 1")){
            player.GetComponent<Player1>().setCharacter(character);
        }
        else{
            player.GetComponent<Player2>().setCharacter(character);
        }
    }

}
