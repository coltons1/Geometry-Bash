using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ihatecharacterselect : MonoBehaviour
{
    [SerializeField] private Image image;
    [SerializeField] private Color color;

    // Start is called before the first frame update
    void Start()
    {
        //this project is lame
        color.a = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick(){
        image.color = color;
    }

}