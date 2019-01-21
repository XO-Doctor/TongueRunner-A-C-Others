using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ammount : MonoBehaviour {

    public int wood;
    public int steel;
    public int nuts;
    public int battery;
    public Text woodtext;
    public Text steeltext;
    public Text nutstext;
    public Text batterytext;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        wood = PlayerPrefs.GetInt("SavedWoods");
        woodtext.text = wood.ToString();
        steel = PlayerPrefs.GetInt("SavedMetals");
        steeltext.text = steel.ToString();
        nuts = PlayerPrefs.GetInt("SavedNuts");
        nutstext.text = nuts.ToString();
        battery = PlayerPrefs.GetInt("SavedBatteries");
        batterytext.text = battery.ToString();
    }
}
