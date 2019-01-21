using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DragandDrop : MonoBehaviour
{
    public bool woodia;
    public bool nothing;
    public bool steelia;
    public bool batteria;
    public bool nutsia;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void wood()
    {
        woodia = true;
        nothing = false;
        steelia = false;
        batteria = false;
        nutsia = false;
    }

    public void steel()
    {
        steelia = true;
        woodia = false;
        nothing = false;
        batteria = false;
        nutsia = false;
    }

    public void nuts()
    {
        nutsia = true;
        woodia = false;
        nothing = false;
        steelia = false;
        batteria = false;
    }

    public void battery()
    {
        steelia = false;
        woodia = false;
        nothing = false;
        batteria = true;
        nutsia = false;
    }

}
