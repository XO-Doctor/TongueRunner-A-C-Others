using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardShower : MonoBehaviour {

    public cardlist clist;
    public List<GameObject> slot = new List<GameObject>();
    public select sel;
    public bool adddthing;
    public CardDisplay carddisplay;
    public cardlist cl;
    public int cardsnumso;

	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update ()
    {
            if (sel.loaded)
            {
                foreach (GameObject fooObj in GameObject.FindGameObjectsWithTag("slot"))
                {
                    slot.Add(fooObj);
                }
                sel.loaded = false;
                adddthing = true;
            }      

            if (adddthing)
            {
                  card1();  
            }

    }

    public void card1()
    {
        carddisplay = slot[cardsnumso].GetComponent<CardDisplay>();
        carddisplay.Card = cl.cardes[cardsnumso];
        cardsnumso++;
        card2();
    }

    public void card2()
    {
        carddisplay = slot[cardsnumso].GetComponent<CardDisplay>();
        carddisplay.Card = cl.cardes[cardsnumso];
        cardsnumso++;
        card1();
    }

}
