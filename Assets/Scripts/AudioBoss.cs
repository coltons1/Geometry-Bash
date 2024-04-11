using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioBoss : MonoBehaviour
{

    public AudioClip Hero;
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
    }

    // Update is called once per frame
    public void SetAudioP1()
    {
        p1Char = p1.GetComponent<Player1>().getCharacter();

        switch(p1Char){
            case "Hero":
                p1.GetComponent<AudioSource>().clip = Hero;
                Debug.Log("Assigned");
                break;

            case "Knight":
                p1.GetComponent<AudioSource>().clip = Knight;
                Debug.Log("Assigned");
                break;

            case "Bandit":
                p1.GetComponent<AudioSource>().clip = Bandit;
                Debug.Log("Assigned");
                break;
            
            case "Warrior":
                p1.GetComponent<AudioSource>().clip = Warrior;
                Debug.Log("Assigned");
                break;
        }
    }

    public void SetAudioP2(){
        p2Char = p2.GetComponent<Player2>().getCharacter();

        switch(p2Char){
            case "Hero":
                p2.GetComponent<AudioSource>().clip = Hero;
                Debug.Log("Assigned");
                break;

            case "Knight":
                p2.GetComponent<AudioSource>().clip = Knight;
                Debug.Log("Assigned");
                break;

            case "Bandit":
                p2.GetComponent<AudioSource>().clip = Bandit;
                Debug.Log("Assigned");
                break;
            
            case "Warrior":
                p2.GetComponent<AudioSource>().clip = Warrior;
                Debug.Log("Assigned");
                break;
        }

    }
}
