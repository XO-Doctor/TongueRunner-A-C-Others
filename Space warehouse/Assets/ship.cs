using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ship : MonoBehaviour {

    public GameObject currentbase;
    public GameObject currentwing;
    public int cats;
    public int dogs;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        cats = PlayerPrefs.GetInt("singleid");
        dogs = PlayerPrefs.GetInt("singlewingid");
    }
}
