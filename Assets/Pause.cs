using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    public GameObject PauseCanvas;
    public GameObject ControlsImageObj; 
    public Image ControlsImage;
    public GameObject ControlsBackObj;
    public Image ControlsBackImage;
    public Button BackButton;
    private GameObject p1;
    private GameObject p2;

    // Start is called before the first frame update
    void Start()
    {
        //try putting this into load scene assets
        //Tutorial Screen variables
        ControlsImageObj = GameObject.Find("ControlsScreen");
        ControlsImage = ControlsImageObj.GetComponent<Image>();
        
        //Back Button variables
        ControlsBackObj = GameObject.Find("ControlsBack");
        ControlsBackImage = ControlsBackObj.GetComponent<Image>();
        BackButton = ControlsBackObj.GetComponent<Button>();

        //Sets everything off on start
        
        ControlsBackImage.enabled = false;
        BackButton.enabled = false;
        ControlsImage.enabled = false;

        PauseCanvas = GameObject.Find("Pause");

        PauseCanvas.GetComponent<Canvas>().enabled = false;

        p1 = GameObject.Find("Player 1");
        p2 = GameObject.Find("Player 2");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenControls(){
        Debug.Log("Controls Clicked");
        ControlsImage.enabled = true;
        ControlsBackImage.enabled = true;
        BackButton.enabled = true;
        p1.GetComponent<Animator>().enabled = false;
        p2.GetComponent<Animator>().enabled = false;
        
    }

    public void CloseControls(){
        ControlsImage.enabled = false;
        ControlsBackImage.enabled = false;
        BackButton.enabled = false;
        p1.GetComponent<Animator>().enabled = true;
        p2.GetComponent<Animator>().enabled = true;

    }

    public void Unpause(){
        PauseCanvas.GetComponent<Canvas>().enabled = false;
        Time.timeScale = 1;
    }

    public void PauseGame(){
        PauseCanvas.GetComponent<Canvas>().enabled = true;
        Time.timeScale = 0;
    }
}
