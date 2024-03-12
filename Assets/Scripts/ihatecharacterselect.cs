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

    // Start is called before the first frame update
    void Start()
    {
        p1green = GameObject.Find("GreenCharSelect");
        p1blue = GameObject.Find("BlueCharSelect");   
        p1yellow = GameObject.Find("YellowCharSelect");
        p1red = GameObject.Find("RedCharSelect");

    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.GetChild(0).gameObject.activeSelf == true){
        //Debug.Log("Green active");
            if(this == p1green){
                p1blue.transform.GetChild(0).gameObject.SetActive(false);
                Debug.Log("Green active");
                p1yellow.transform.GetChild(0).gameObject.SetActive(false);
                p1red.transform.GetChild(0).gameObject.SetActive(false);
            }
            else if(this == p1blue){
                p1green.transform.GetChild(0).gameObject.SetActive(false);
                p1yellow.transform.GetChild(0).gameObject.SetActive(false);
                p1red.transform.GetChild(0).gameObject.SetActive(false);
            }
            else if(this == p1yellow){
                p1blue.transform.GetChild(0).gameObject.SetActive(false);
                p1green.transform.GetChild(0).gameObject.SetActive(false);
                p1red.transform.GetChild(0).gameObject.SetActive(false);
            }
            else if(this == p1red){
                p1blue.transform.GetChild(0).gameObject.SetActive(false);
                p1yellow.transform.GetChild(0).gameObject.SetActive(false);
                p1green.transform.GetChild(0).gameObject.SetActive(false);
            }
        }
    }

    public void OnClick(){
        this.transform.GetChild(0).gameObject.SetActive(true);
    }
}