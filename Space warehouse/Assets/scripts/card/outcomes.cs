using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class outcomes : MonoBehaviour
{
    public int text;
    public RecInfo rec;
    public bool active;
    public List<card> listcard = new List<card>();
    public List<int> listid = new List<int>();
    card[] enemies = Resources.LoadAll<card>("cards");
    public bool added;
    public bool added2;
    public Outcome outcome;
    public bool added3;
    public bool added4;
    public bool added5;
    public bool added6;
    public bool added7;

    private void Start()
    {
        if (PlayerPrefs.GetInt("base1") != 0)
        {
            added = true;
            listid.Add(112212);
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
            listid.Add(111222);
        }
        else
        {
            added2 = false;
        }
        if (PlayerPrefs.GetInt("base3") != 0)
        {
            added3 = true;
            listid.Add(111111);
            outcome.ids.Add(111111);
        }
        else
        {
            added3 = false;
        }
        if (PlayerPrefs.GetInt("base4") != 0)
        {
            added4 = true;
            listid.Add(234432);
            outcome.ids.Add(234432);
        }
        else
        {
            added4 = false;
        }
    }

    public void Update()
    {
        if (rec.fullid == 112212)
        {
            if (rec.id1a == 10)
            {
                if (rec.id2a == 50)
                {
                    if (rec.id3a == 50)
                    {
                        if (rec.id4a == 20)
                        {
                            if (rec.id5a == 10)
                            {
                                if (rec.id6a == 50)
                                {
                                    Add();
                                }
                            }
                        }
                    }
                }
            }
        }

        if (rec.fullid == 111222)
        {
            if (rec.id1a == 20)
            {
                if (rec.id2a == 20)
                {
                    if (rec.id3a == 40)
                    {
                        if (rec.id4a == 30)
                        {
                            if (rec.id5a == 10)
                            {
                                if (rec.id6a == 50)
                                {
                                    Add1();
                                }
                            }
                        }
                    }
                }
            }
        }
        if (rec.fullid == 111111)
        {
            if (rec.id1a == 20)
            {
                if (rec.id2a == 20)
                {
                    if (rec.id3a == 50)
                    {
                        if (rec.id4a == 50)
                        {
                            if (rec.id5a == 20)
                            {
                                if (rec.id6a == 20)
                                {
                                    Add3();
                                }
                            }
                        }
                    }
                }
            }
        }
        if (rec.fullid == 234432)
        {
            if (rec.id1a == 100)
            {
                if (rec.id2a == 150)
                {
                    if (rec.id3a == 50)
                    {
                        if (rec.id4a == 50)
                        {
                            if (rec.id5a == 150)
                            {
                                if (rec.id6a == 100)
                                {
                                    Add4();
                                }
                            }
                        }
                    }
                }
            }
        }

    }

    public void Add()
    {
        if (added == false)
        {
            //listcard.Add(Card);
            listid.Add(112212);
            added = true;
            PlayerPrefs.SetInt("base1", 112212);
        }
    }

    public void Add1()
    {
        if (added2 == false)
        {
            //listcard.Add(Card);
            listid.Add(111222);
            added2 = true;
            PlayerPrefs.SetInt("base2", 111222);
        }
    }
    public void Add3()
    {
        if (added3 == false)
        {
            //listcard.Add(Card);
            listid.Add(111111);
            added2 = true;
            PlayerPrefs.SetInt("base3", 111111);
        }
    }
    public void Add4()
    {
        if (added4 == false)
        {
            //listcard.Add(Card);
            listid.Add(234432);
            added4 = true;
            PlayerPrefs.SetInt("base4", 234432);
        }
    }

}


