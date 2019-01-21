using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Craftingrec : MonoBehaviour {

    public Sprite wood;
    public Sprite metal;
    public Sprite nuts;
    public Sprite steel;
    public DragandDrop dad;
    public Image currrentimage;
    public Sprite woodart;
    public RecInfo rec;
    public Sprite stellart;
    public Sprite batteryart;
    public Sprite nutart;
    public Image slot1;
    public Image slot2;
    public Image slot3;
    public Image slot4;
    public Image slot5;
    public Image slot6;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update () {
		
	}

    public void clickedon()
    {
        if (dad.woodia == true)
        {
            if (rec.validid1 == false)
            {
                slot1.sprite = woodart;
                rec.id1 = 1;
                rec.validid1 = true;
            }
            else
            {
                if (rec.validid2 == false)
                {
                    slot2.sprite = woodart;
                    rec.id2 = 1;
                    rec.validid2 = true;
                }
                else
                {
                    if (rec.validid3 == false)
                    {
                        slot3.sprite = woodart;
                        rec.id3 = 1;
                        rec.validid3 = true;
                    }
                    else
                    {
                        if (rec.validid4 == false)
                        {
                            slot4.sprite = woodart;
                            rec.id4 = 1;
                            rec.validid4 = true;
                        }
                        else
                        {
                            if (rec.validid5 == false)
                            {
                                slot5.sprite = woodart;
                                rec.id5 = 1;
                                rec.validid5 = true;
                            }
                            else
                            {
                                if (rec.validid6 == false)
                                {
                                    slot6.sprite = woodart;
                                    rec.id6 = 1;
                                    rec.validid6 = true;                                   
                                }
                            }
                        }
                    }
                }
            }
        }
        if (dad.steelia == true)
        {
            if (rec.validid1 == false)
            {
                slot1.sprite = stellart;
                rec.id1 = 2;
                rec.validid1 = true;
            }
            else
            {
                if (rec.validid2 == false)
                {
                    slot2.sprite = stellart;
                    rec.id2 = 2;
                    rec.validid2 = true;
                }
                else
                {
                    if (rec.validid3 == false)
                    {
                        slot3.sprite = stellart;
                        rec.id3 = 2;
                        rec.validid3 = true;
                    }
                    else
                    {
                        if (rec.validid4 == false)
                        {
                            slot4.sprite = stellart;
                            rec.id4 = 2;
                            rec.validid4 = true;
                        }
                        else
                        {
                            if (rec.validid5 == false)
                            {
                                slot5.sprite = stellart;
                                rec.id5 = 2;
                                rec.validid5 = true;
                            }
                            else
                            {
                                if (rec.validid6 == false)
                                {
                                    slot6.sprite = stellart;
                                    rec.id6 = 2;
                                    rec.validid6 = true;
                                }
                            }
                        }
                    }
                }
            }
        }
        if (dad.nutsia == true)
        {
            if (rec.validid1 == false)
            {
                slot1.sprite = nutart;
                rec.id1 = 3;
                rec.validid1 = true;
            }
            else
            {
                if (rec.validid2 == false)
                {
                    slot2.sprite = nutart;
                    rec.id2 = 3;
                    rec.validid2 = true;
                }
                else
                {
                    if (rec.validid3 == false)
                    {
                        slot3.sprite = nutart;
                        rec.id3 = 3;
                        rec.validid3 = true;
                    }
                    else
                    {
                        if (rec.validid4 == false)
                        {
                            slot4.sprite = nutart;
                            rec.id4 = 3;
                            rec.validid4 = true;
                        }
                        else
                        {
                            if (rec.validid5 == false)
                            {
                                slot5.sprite = nutart;
                                rec.id5 = 3;
                                rec.validid5 = true;
                            }
                            else
                            {
                                if (rec.validid6 == false)
                                {
                                    slot6.sprite = nutart;
                                    rec.id6 = 3;
                                    rec.validid6 = true;
                                }
                            }
                        }
                    }
                }
            }
        }
        if (dad.batteria == true)
        {
            if (rec.validid1 == false)
            {
                slot1.sprite = batteryart;
                rec.id1 = 4;
                rec.validid1 = true;
            }
            else
            {
                if (rec.validid2 == false)
                {
                    slot2.sprite = batteryart;
                    rec.id2 = 4;
                    rec.validid2 = true;
                }
                else
                {
                    if (rec.validid3 == false)
                    {
                        slot3.sprite = batteryart;
                        rec.id3 = 4;
                        rec.validid3 = true;
                    }
                    else
                    {
                        if (rec.validid4 == false)
                        {
                            slot4.sprite = batteryart;
                            rec.id4 = 4;
                            rec.validid4 = true;
                        }
                        else
                        {
                            if (rec.validid5 == false)
                            {
                                slot5.sprite = batteryart;
                                rec.id5 = 4;
                                rec.validid5 = true;
                            }
                            else
                            {
                                if (rec.validid6 == false)
                                {
                                    slot6.sprite = batteryart;
                                    rec.id6 = 4;
                                    rec.validid6 = true;
                                }
                            }
                        }
                    }
                }
            }
        }
    }

}
