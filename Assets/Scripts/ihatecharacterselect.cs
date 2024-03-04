using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ihatecharacterselect : MonoBehaviour
{
    [SerializeField] private Image image;
    [SerializeField] private Color color;
    private GameObject border;
    public bool isActive = false;

    // Start is called before the first frame update
    void Start()
    {
        border = GameObject.Find("greenborder");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick(){
        border.SetActive(true);
        isActive = true;
    }

}