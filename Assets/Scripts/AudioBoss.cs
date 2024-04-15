using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioBoss : MonoBehaviour
{

    public AudioClip HeroM;
    public AudioClip KnightM;
    public AudioClip BanditM;
    public AudioClip WarriorM;

    public AudioClip HeroR;
    public AudioClip KnightR;
    public AudioClip BanditR;
    public AudioClip WarriorR;


    public GameObject p1;
    public GameObject p2;

    public string p1Char;
    public string p2Char;

    public AudioSource[] AudioSourcesP1;
    public AudioSource[] AudioSourcesP2;

    

    // Start is called before the first frame update
    void Start()
    {
        p1 = GameObject.Find("Player 1");
        p2 = GameObject.Find("Player 2");

        AudioSourcesP1 = p1.GetComponents<AudioSource>();
        AudioSourcesP2 = p2.GetComponents<AudioSource>(); 



    }

    // Update is called once per frame
    public void SetAudioP1()
    {
        p1Char = p1.GetComponent<Player1>().getCharacter();

        switch(p1Char){
            case "Hero":
                //Melee Sound FX
                for(int i = 0; i < 2; i++){
                    AudioSourcesP1[0].clip = HeroM;
                    AudioSourcesP1[1].clip = HeroR;
                }
                //p1.GetComponent<AudioSource>().clip = HeroM;
                Debug.Log("Assigned");
                break;

            case "Knight":
                //Melee Sound FX
                p1.GetComponent<AudioSource>().clip = KnightM;
                Debug.Log("Assigned");
                break;

            case "Bandit":
                //Melee Sound FX
                p1.GetComponent<AudioSource>().clip = BanditM;
                Debug.Log("Assigned");
                break;
            
            case "Warrior":
                //Melee Sound FX
                p1.GetComponent<AudioSource>().clip = WarriorM;
                Debug.Log("Assigned");
                break;
        }
    }

    public void SetAudioP2(){
        p2Char = p2.GetComponent<Player2>().getCharacter();

        switch(p2Char){
            case "Hero":
                //Melee Sound FX
                p2.GetComponent<AudioSource>().clip = HeroM;
                Debug.Log("Assigned");
                break;

            case "Knight":
                //Melee Sound FX
                p2.GetComponent<AudioSource>().clip = KnightM;
                Debug.Log("Assigned");
                break;

            case "Bandit":
                //Melee Sound FX
                p2.GetComponent<AudioSource>().clip = BanditM;
                Debug.Log("Assigned");
                break;
            
            case "Warrior":
                //Melee Sound FX
                p2.GetComponent<AudioSource>().clip = WarriorM;
                Debug.Log("Assigned");
                break;
        }

    }
}
