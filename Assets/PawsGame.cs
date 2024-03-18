using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PawsGame : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject Paws;
    void Start()
    {
        Paws = GameObject.Find("Paws");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.G)){
            Paws.GetComponent<Pause>().PauseGame();
        }
    }
}
