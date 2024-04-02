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
    private GameObject p1, p2, h;


    // Start is called before the first frame update
    void Start()
    {
        //try putting this into load scene assets
        //Tutorial Screen variables
        ControlsImageObj = GameObject.Find("ControlsScreen");
        
        
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
        h = GameObject.Find("Healthbars");
        
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
        p1.GetComponent<SpriteRenderer>().enabled = false;
        p2.GetComponent<SpriteRenderer>().enabled = false;
        h.GetComponent<Canvas>().enabled = false;
        Debug.Log("disappear");

    }

    public void CloseControls(){
        ControlsImage.enabled = false;
        ControlsBackImage.enabled = false;
        BackButton.enabled = false;
        p1.GetComponent<SpriteRenderer>().enabled = true;
        p2.GetComponent<SpriteRenderer>().enabled = true;
        h.GetComponent<Canvas>().enabled = true;

    }

    public void Unpause(){
        //Enables Player 1 and 2 player controllers.
        p1.GetComponent<Player1>().enabled = true;
        p2.GetComponent<Player2>().enabled = true;
        //Disables Pause Canvas.
        PauseCanvas.GetComponent<Canvas>().enabled = false;
        //Unfreezes all animations.
        Time.timeScale = 1;
    }

    public void PauseGame(){
        //Disables Player 1 and 2 player controllers.
        p1.GetComponent<Player1>().enabled = false;
        p2.GetComponent<Player2>().enabled = false;
        //Enables Pause Canvas.
        PauseCanvas.GetComponent<Canvas>().enabled = true;
        //Freezes all animations.
        Time.timeScale = 0;
    }

    public void HideCharacters(){
        
    }
}
