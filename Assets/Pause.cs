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
    
    private bool isPaused;

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
    }

    public void CloseControls(){
        ControlsImage.enabled = false;
        ControlsBackImage.enabled = false;
        BackButton.enabled = false;

    }

    public void Unpause(){
        PauseCanvas.GetComponent<Canvas>().enabled = false;
        isPaused = false;
        Time.timeScale = 1;
    }

    public void PauseGame(){
        PauseCanvas.GetComponent<Canvas>().enabled = true;
        isPaused = true;
        Time.timeScale = 0;
    }
}
