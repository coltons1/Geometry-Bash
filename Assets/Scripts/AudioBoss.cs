using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioBoss : MonoBehaviour
{

    public AudioClip HeroM;
    public AudioClip KnightM;
    public AudioClip BanditM;
    public AudioClip WarriorM;

    public AudioClip RangeAttack;
    public AudioClip Damaged;
    public AudioClip Died;


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
                AudioSourcesP1[0].clip = HeroM;
                AudioSourcesP1[1].clip = RangeAttack;
                AudioSourcesP1[2].clip = Damaged;
                AudioSourcesP1[3].clip = Died;
                
                //p1.GetComponent<AudioSource>().clip = HeroM;
                Debug.Log("Assigned");
                break;

            case "Knight":
                //Melee Sound FX
                AudioSourcesP1[0].clip = KnightM;
                AudioSourcesP1[1].clip = RangeAttack;
                AudioSourcesP1[2].clip = Damaged;
                AudioSourcesP1[3].clip = Died;
                
                Debug.Log("Assigned");
                break;

            case "Bandit":
                //Melee Sound FX
                AudioSourcesP1[0].clip = BanditM;
                AudioSourcesP1[1].clip = RangeAttack;
                AudioSourcesP1[2].clip = Damaged;
                AudioSourcesP1[3].clip = Died;
                
                Debug.Log("Assigned");
                break;
            
            case "Warrior":
                //Melee Sound FX
                AudioSourcesP1[0].clip = WarriorM;
                AudioSourcesP1[1].clip = RangeAttack;
                AudioSourcesP1[2].clip = Damaged;
                AudioSourcesP1[3].clip = Died;
                
                Debug.Log("Assigned");
                break;
        }
    }

    public void SetAudioP2(){
        p2Char = p2.GetComponent<Player2>().getCharacter();

        switch(p2Char){
            case "Hero":
                //Melee Sound FX
                
                AudioSourcesP2[0].clip = HeroM;
                AudioSourcesP2[1].clip = RangeAttack;
                AudioSourcesP2[2].clip = Damaged;
                AudioSourcesP2[3].clip = Died;
                
                Debug.Log("Assigned");
                break;

            case "Knight":
                //Melee Sound FX
                AudioSourcesP2[0].clip = KnightM;
                AudioSourcesP2[1].clip = RangeAttack;
                AudioSourcesP2[2].clip = Damaged;
                AudioSourcesP2[3].clip = Died;
                
                Debug.Log("Assigned");
                break;

            case "Bandit":
                //Melee Sound FX
                AudioSourcesP2[0].clip = BanditM;
                AudioSourcesP2[1].clip = RangeAttack;
                AudioSourcesP2[2].clip = Damaged;
                AudioSourcesP2[3].clip = Died;
                
                Debug.Log("Assigned");
                break;
            
            case "Warrior":
                //Melee Sound FX
                AudioSourcesP2[0].clip = WarriorM;
                AudioSourcesP2[1].clip = RangeAttack;
                AudioSourcesP2[2].clip = Damaged;
                AudioSourcesP2[3].clip = Died;

                Debug.Log("Assigned");
                break;
        }

    }
}
