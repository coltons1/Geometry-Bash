using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AnimationChange : MonoBehaviour
{
    public RuntimeAnimatorController controller;
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
