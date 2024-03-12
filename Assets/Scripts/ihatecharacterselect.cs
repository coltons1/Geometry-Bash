using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ihatecharacterselect : MonoBehaviour
{

    public bool greenActive = false;
    public GameObject p1green;
    public GameObject p1blue;
    public GameObject p1yellow;
    public GameObject p1red;
    public GameObject p2green;
    public GameObject p2blue;
    public GameObject p2yellow;
    public GameObject p2red;


    // Start is called before the first frame update
    void Start()
    {
        p1green = GameObject.Find("GreenCharSelect");
        p1blue = GameObject.Find("BlueCharSelect");   
        p1yellow = GameObject.Find("YellowCharSelect");
        p1red = GameObject.Find("RedCharSelect");

        p2green = GameObject.Find("GreenCharSelect player 2");
        p2blue = GameObject.Find("BlueCharSelect player 2");   
        p2yellow = GameObject.Find("YellowCharSelectplayer 2");
        p2red = GameObject.Find("RedCharSelect player 2");

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClick(){
        this.transform.GetChild(0).gameObject.SetActive(true);
        if(this.gameObject == p1green){
            p1blue.transform.GetChild(0).gameObject.SetActive(false);
            p1yellow.transform.GetChild(0).gameObject.SetActive(false);                
            p1red.transform.GetChild(0).gameObject.SetActive(false);
        }
        else if(this.gameObject == p1blue){
            p1green.transform.GetChild(0).gameObject.SetActive(false);
            p1yellow.transform.GetChild(0).gameObject.SetActive(false);
            p1red.transform.GetChild(0).gameObject.SetActive(false);
        }
        else if(this.gameObject == p1yellow){
            p1blue.transform.GetChild(0).gameObject.SetActive(false);
            p1green.transform.GetChild(0).gameObject.SetActive(false);
            p1red.transform.GetChild(0).gameObject.SetActive(false);
        }
        else if(this.gameObject == p1red){
            p1blue.transform.GetChild(0).gameObject.SetActive(false);
            p1yellow.transform.GetChild(0).gameObject.SetActive(false);
            p1green.transform.GetChild(0).gameObject.SetActive(false);
        }

        //player 2 boxes
        if(this.gameObject == p2green){
            p2blue.transform.GetChild(0).gameObject.SetActive(false);
            p2yellow.transform.GetChild(0).gameObject.SetActive(false);                
            p2red.transform.GetChild(0).gameObject.SetActive(false);
        }
        else if(this.gameObject == p2blue){
            p2green.transform.GetChild(0).gameObject.SetActive(false);
            p2yellow.transform.GetChild(0).gameObject.SetActive(false);
            p2red.transform.GetChild(0).gameObject.SetActive(false);
        }
        else if(this.gameObject == p2yellow){
            p2blue.transform.GetChild(0).gameObject.SetActive(false);
            p2green.transform.GetChild(0).gameObject.SetActive(false);
            p2red.transform.GetChild(0).gameObject.SetActive(false);
        }
        else if(this.gameObject == p2red){
            p2blue.transform.GetChild(0).gameObject.SetActive(false);
            p2yellow.transform.GetChild(0).gameObject.SetActive(false);
            p2green.transform.GetChild(0).gameObject.SetActive(false);
        }
    }
}