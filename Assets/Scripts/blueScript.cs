using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class blueScript : MonoBehaviour
{
    private GameObject charSelect;
    public bool blueActive;
    // Start is called before the first frame update
    void Start()
    {
        charSelect = GameObject.Find("BlueCharSelect");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClick(){
        charSelect.transform.GetChild(0).gameObject.SetActive(true);
        blueActive = true;
    }

    public bool getBlue(){
        return blueActive;
    }
}
