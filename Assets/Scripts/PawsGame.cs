using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PawsGame : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject Paws;
    public bool isPaused;
    void Start()
    {
        isPaused = false;
        Paws = GameObject.Find("Paws");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.G) && isPaused != true){
            Paws.GetComponent<Pause>().PauseGame();
            isPaused = true;
        } else if(Input.GetKeyDown(KeyCode.G) && isPaused == true){
            Paws.GetComponent<Pause>().Unpause();
            isPaused = false;
        }

    }
}
