using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvenSaver : MonoBehaviour {

    public bool added;
    public bool added2;
    public bool added3;
    public Outcome outcome;
    public bool added4;

    // Use this for initialization
    void Start () {
        if (PlayerPrefs.GetInt("base1") != 0)
        {
            added = true;
            outcome.ids.Add(112212);
        }
        else
        {
            added = false;
        }
        if (PlayerPrefs.GetInt("base2") != 0)
        {
            added2 = true;
            outcome.ids.Add(111222);
        }
        else
        {
            added2 = false;
        }
        if (PlayerPrefs.GetInt("base3") != 0)
        {
            added3 = true;
            outcome.ids.Add(111111);
        }
        else
        {
            added3 = false;
        }
        if (PlayerPrefs.GetInt("base2") != 0)
        {
            added4 = true;
            outcome.ids.Add(234432);
        }
        else
        {
            added4 = false;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
