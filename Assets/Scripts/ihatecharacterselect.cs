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
        charSelect = GameObject.Find("GreenCharSelect");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick(){
        charSelect.transform.GetChild(0).gameObject.SetActive(true);
        isActive = true;
    }

}