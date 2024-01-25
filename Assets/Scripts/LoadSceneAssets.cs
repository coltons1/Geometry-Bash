using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneAssets : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject p1, p2;
    private GameObject h1, h2;
    [SerializeField] int p1x, p1y, p2x, p2y;
    
    Scene currentScene;
    //HealthController healthController;

    void Awake()
    {
        currentScene = SceneManager.GetActiveScene();

        if(currentScene.name == "Stage1")
        {
            p1 = GameObject.Find("Player 1");
            p2 = GameObject.Find("Player 2");

        }
    }

    //sets p1 position to (p1x,p1y) and p2 position to (p2x,p2y)
    public void setPositions()
    {
        //assigns p1 and p2 to player 1 & player 2
        p1 = GameObject.Find("Player 1");
        p2 = GameObject.Find("Player 2");
        

        //allows players 1 and 2 to move
        p1.GetComponent<Rigidbody2D>().isKinematic = false;
        p2.GetComponent<Rigidbody2D>().isKinematic = false;

        //sets p1 position and velocity
        p1.transform.position = new Vector2(p1x, p1y);
        p1.GetComponent<Rigidbody2D>().velocity = new Vector2(0.0f,0.0f);
        
        //sets p2 position and velocity
        p2.transform.position = new Vector2(p2x, p2y);
        p2.GetComponent<Rigidbody2D>().velocity = new Vector2(0.0f,0.0f);




        //assigns h1 and h2 to player 1 health bar and player 2 healthbar
        h1 = GameObject.Find("P1HealthBar");


        //displays player 1 healthbar
        h1.transform.GetChild(0).gameObject.SetActive(true);
        h1.transform.GetChild(1).gameObject.SetActive(true);

        h2 = GameObject.Find("P2HealthBar");

        h2.transform.GetChild(0).gameObject.SetActive(true);
        h2.transform.GetChild(1).gameObject.SetActive(true);






    }


}
