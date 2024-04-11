using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioBoss : MonoBehaviour
{

    public AudioClip HeroKnight;
    public AudioClip Knight;
    public AudioClip Bandit;
    public AudioClip Warrior;

    public GameObject p1;
    public GameObject p2;

    public string p1Char;
    public string p2Char;

    

    // Start is called before the first frame update
    void Start()
    {
        p1 = GameObject.Find("Player 1");
        p2 = GameObject.Find("Player 2");

        p1Char = p1.GetComponent<Player1>().getCharacter();
        p2Char = p2.GetComponent<Player2>().getCharacter();


        
    }

    // Update is called once per frame
    public void SetAudioClips()
    {
        switch(p1Char){
            case "HeroKnight":
                p1.GetComponent<AudioSource>().clip = HeroKnight;
                break;

            case "Knight":
                p1.GetComponent<AudioSource>().clip = Knight;
                break;

            case "Bandit":
                p1.GetComponent<AudioSource>().clip = Bandit;
                break;
            
            case "Warrior":
                p1.GetComponent<AudioSource>().clip = Warrior;
                break;
        }

        switch(p2Char){
            case "HeroKnight":
                p2.GetComponent<AudioSource>().clip = HeroKnight;
                break;

            case "Knight":
                p2.GetComponent<AudioSource>().clip = Knight;
                break;

            case "Bandit":
                p2.GetComponent<AudioSource>().clip = Bandit;
                break;
            
            case "Warrior":
                p2.GetComponent<AudioSource>().clip = Warrior;
                break;
        }
    }
}
