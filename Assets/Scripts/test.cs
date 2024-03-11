using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ihatecharacterselect : MonoBehaviour
{
    [SerializeField] private Image image;
    [SerializeField] private Color color;
    private GameObject charSelect;
    public bool isActive = false;

    // Start is called before the first frame update
    void Start()
    {
        p1Green = GameObject.Find("GreenCharSelect");
        p1Blue = GameObject.FInd("BlueCharSelect");
        p1Red = 

    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.GetChild(0).gameObject.activeSelf() == true){
            if(this == p1Green){
                p1Blue.transform.GetChild(0).gameObject.SetActive(false);
                p1Red.transform.GetChild(0).gameObject.SetActive(false);
            }
            else if(this == p1Blue){
                p1Green.transform.GetChild(0).gameObject.SetActive(false);
                p1Red.transform.GetChild(0).gameObject.SetActive(false);

            }
            else if(this == p1Red){
                p1Green.transform.GetChild(0).gameObject.SetActive(false);
                p1Green.transform.GetChild(0).gameObject.SetActive(false);

            }
        }

        
    }

    public void OnClick(){
        this.transform.GetChild(0).gameObject.SetActive(true);
    }

}