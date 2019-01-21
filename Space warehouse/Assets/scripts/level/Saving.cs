using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saving : MonoBehaviour {

    public int SavedWood;
    public int SavedMetal;
    public int SavedNut;
    public int SavedBattery;
    public Resourcesdab resourcesdab;
    public outcomes CardDisplay;
    // Use this for initialization

    void Start () {
        SavedWood = PlayerPrefs.GetInt("SavedWoods");
        SavedMetal = PlayerPrefs.GetInt("SavedMetals");
        SavedNut = PlayerPrefs.GetInt("SavedNuts");
        SavedBattery = PlayerPrefs.GetInt("SavedBatteries");
    }
	
	// Update is called once per frame
	void Update () {
        if (PlayerPrefs.GetInt("SavedWoods") != SavedWood)
        {
            PlayerPrefs.SetInt("SavedWoods", SavedWood);
            PlayerPrefs.Save();
        }
        if (PlayerPrefs.GetInt("SavedMetals") != SavedMetal)
        {
            PlayerPrefs.SetInt("SavedMetals", SavedMetal);
            PlayerPrefs.Save();
        }
        if (PlayerPrefs.GetInt("SavedNuts") != SavedNut)
        {
            PlayerPrefs.SetInt("SavedNuts", SavedNut);
            PlayerPrefs.Save();
        }
        if (PlayerPrefs.GetInt("SavedBatteries") != SavedBattery)
        {
            PlayerPrefs.SetInt("SavedBatteries", SavedBattery);
            PlayerPrefs.Save();
        }
        PlayerPrefs.SetInt("myList_count", CardDisplay.listid.Count);

        SavedWood = resourcesdab.wooda;
        SavedMetal = resourcesdab.steela;
        SavedNut = resourcesdab.nutsa;
        SavedBattery = resourcesdab.batterya;

    }

}
