using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipcollider : MonoBehaviour {

    public GameObject life1;
    public GameObject life2;
    public GameObject life3;
    public float lives;
    public bool baseb;
    public float livesw;

    public void Start()
    {

    }

    void Awake()
    { this.life1 = GameObject.Find("life1");
        this.life2 = GameObject.Find("life2");

        this.life3 = GameObject.Find("life3");
    }

    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Recource")
        {
            Destroy(col.gameObject);
        }
        if (baseb)
        {
            if (col.gameObject.tag == "Meteor")
            {
                if (lives == 4)
                {
                    lives = 3;
                    Destroy(col.gameObject);
                }
                else
                {
                    if (lives == 3)
                    {
                        lives = 2;
                        Destroy(life1);
                        Destroy(col.gameObject);
                    }
                    else
                    {
                        if (lives == 2)
                        {
                            lives = 1;
                            Destroy(life2);
                            Destroy(col.gameObject);
                        }
                        else
                        {
                            if (lives == 1)
                            {
                                lives = 0;
                                Destroy(life3);
                                Destroy(gameObject);
                                Destroy(col.gameObject);
                            }
                        }
                    }
                }
            }
        }
        if (baseb == false)
        {
            if (col.gameObject.tag == "Meteor")
            {
                if (lives == 4)
                {
                    lives = 3;
                    Destroy(col.gameObject);
                }
                else
                {
                    if (livesw == 3)
                    {
                        livesw = 2;
                        Destroy(col.gameObject);
                    }
                    else
                    {
                        if (livesw == 2)
                        {
                            livesw = 1;
                            Destroy(col.gameObject);
                        }
                        else
                        {
                            if (livesw == 1)
                            {
                                livesw = 0;
                                Destroy(gameObject);
                                Destroy(col.gameObject);
                            }
                        }
                    }
                }
                
            }
        }       

    }
}
