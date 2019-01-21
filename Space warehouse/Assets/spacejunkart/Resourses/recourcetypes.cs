using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recourcetypes : MonoBehaviour {

    public levelmanager manager;
    public float IDtype;
    public Resourcesdab ressd;
    public Sprite wood;
    public Sprite steel;
    public Sprite NutsBolts;
    public Sprite Battery;

    

	// Use this for initialization
	void Start () {

        manager = GameObject.FindObjectOfType<levelmanager>();
        ressd = GameObject.FindObjectOfType<Resourcesdab>();

        if (manager.score < 100)
        {
            IDtype = Random.Range(1, 5);
        }
        else
        {
            if (manager.score < 250)
            {
                IDtype = Random.Range(1, 6);
            }
            else
            {
                if (manager.score < 500)
                {
                    IDtype = Random.Range(1, 8);
                }
                else
                {
                    if (manager.score < 1000)
                    {
                        IDtype = Random.Range(1, 10);
                    }
                    else
                    {
                        if (manager.score < 2000)
                        {
                            IDtype = Random.Range(1, 13);
                        }
                        else
                        {
                            if (manager.score > 5000)
                            {
                                IDtype = Random.Range(1, 16);
                            }
                        }
                    }
                }
            }

        }
	}
	
	// Update is called once per frame
	void Update () {

		if (IDtype == 1)
        {

            this.GetComponent<SpriteRenderer>().sprite = wood;
        }
        if (IDtype == 2)
        {

            this.GetComponent<SpriteRenderer>().sprite = steel;
        }
        if (IDtype == 3)
        {

            this.GetComponent<SpriteRenderer>().sprite = NutsBolts;
        }
        if (IDtype == 4)
        {

            this.GetComponent<SpriteRenderer>().sprite = Battery;
        }

    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == ("base"))
        {
            if (IDtype == 1)
            {
                ressd.wooda = ressd.wooda + Random.Range(1, 4);

            }
            if (IDtype == 2)
            {
                ressd.steela = ressd.steela + Random.Range(1, 4);

            }
            if (IDtype == 3)
            {
                ressd.nutsa = ressd.nutsa + Random.Range(1, 4);

            }
            if (IDtype == 4)
            {
                ressd.batterya = ressd.batterya + Random.Range(1, 4);

            }
        }
        

    }
}
