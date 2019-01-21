using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class select : MonoBehaviour {

    public int id;
    public GameObject shipbase;
    public Outcome CardDisplay;
    public int idss;
    public List<int> listid = new List<int>();
    public int vicroy;
    public GameObject cardobject;
    public bool added;
    public int cardsSpawned;
    public int idk;
    public bool loaded;
    public bool loadedloaded;

    // Use this for initialization
    void Start () {

        added = true;
        cardsSpawned = 0;
        cardsSpawned = CardDisplay.ids.Count;
        loaded = false;
        loadedloaded = false;
    }
	
	// Update is called once per frame
	void Update () {
        
        if (added)
        {
            foreach (int isasds in CardDisplay.ids)
            {
                vicroy = vicroy + 1;
                Vector3 dab = new Vector3(0, 0, 0);
                Instantiate(cardobject, dab, Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);
                idk++;
            }
        }
        if (idk >= cardsSpawned)
        {
            added = false;
            load();
        }
    }   
    
    public void load()
    {
        if (loadedloaded ==  false)
        {
            loaded = true;
            loadedloaded = true;
        }        
    }

}
