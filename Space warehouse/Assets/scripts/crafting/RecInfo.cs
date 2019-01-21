using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecInfo : MonoBehaviour {

    public int id1;
    public int id2;
    public int id3;
    public int id4;
    public int id5;
    public int id6;
    public int id1a;
    public int id2a;
    public int id3a;
    public int id4a;
    public int id5a;
    public int id6a;
    private string fullidstring;
    public int fullid;
    private string fullidstringa;
    public int fullida;
    public bool validid1;
    public bool validid2;
    public bool validid3;
    public bool validid4;
    public bool validid5;
    public bool validid6;
    public float active;
    public Text id1as;
    public Text id2as;
    public Text id3as;
    public Text id4as;
    public Text id5as;
    public Text id6as;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
       
        fullidstring = id1.ToString() + id2.ToString() + id3.ToString() + id4.ToString() + id5.ToString() + id6.ToString();

        fullid = int.Parse(fullidstring);

        //fullidstringa = id1a.ToString() + id2a.ToString() + id3a.ToString() + id4a.ToString() + id5a.ToString() + id6a.ToString();

        //fullida = int.Parse(fullidstringa);

        id1a = int.Parse(id1as.text);
        id2a = int.Parse(id2as.text);
        id3a = int.Parse(id3as.text);
        id4a = int.Parse(id4as.text);
        id5a = int.Parse(id5as.text);
        id6a = int.Parse(id6as.text);
    }

    public void testid1()
    {
        id1 = 1;
        validid1 = true;
    }

    public void testid2()
    {
        id2 = 1;
        validid2 = true;
    }
    public void testid3()
    {
        id3 = Random.Range(1, 16);
        validid3 = true;
    }

    public void testid4()
    {
        id4 = Random.Range(1, 16);
        validid4 = true;
    }
    public void testid5()
    {
        id5 = Random.Range(1, 16);
        validid5 = true;
    }

    public void testid6()
    {
        id6 = Random.Range(1, 16);
        validid6 = true;
    }

}
