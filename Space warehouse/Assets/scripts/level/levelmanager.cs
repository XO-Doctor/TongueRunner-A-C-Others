
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelmanager : MonoBehaviour {

    public GameObject meteor;
    public GameObject player;
    private bool spawned = false;
    public GameObject metdel; // meteor deleter
    public Text scoretext;
    public float score;
    public bool scorewait = true;
    public bool starspawned;
    public GameObject star;
    public GameObject cloud1;
    public GameObject cloud2;
    public GameObject cloud3;
    public GameObject cloud4;
    public GameObject currentcloud;
    public bool cspawned;
    private bool cstop;
    // Use this for initialization
    void Start()
    {
        StartCoroutine(wtss());
        scorewait = true;
        starspawned = true;
        scoretext.text = 0.ToString();
        score = 0;
    }

    IEnumerator wtss()
    {
        yield return new WaitForSeconds(90);
        starspawned = false;
        cstop = true;
    }
    IEnumerator CWait()
    {
        cspawned = true;
        yield return new WaitForSeconds(Random.Range(7f, 15f));
        cspawned = false;
    }
    IEnumerator Wait()
    {
            spawned = true;
            yield return new WaitForSeconds(0.5f);
            spawned = false;          
    }
    IEnumerator SWait()
    {
        starspawned = true;
        yield return new WaitForSeconds(0.2f);
        starspawned = false;
    }

    IEnumerator secwait()
    {
        scorewait = false;
        yield return new WaitForSeconds(0.2f);
        scorewait = true;
    }

    // Update is called once per frame
    void Update () {
        if (spawned == false)
        {
            Vector2 posi = new Vector2(Random.Range(-9, 9), 10);
            Instantiate(meteor, posi, Quaternion.identity);
            StartCoroutine(Wait());
        }
        if (cstop == false)
        {
            if (cspawned == false)
            {
                float cur = Random.Range(1, 5);
                if (cur == 1)
                {
                    currentcloud = cloud1;
                }
                if (cur == 2)
                {
                    currentcloud = cloud2;
                }
                if (cur == 3)
                {
                    currentcloud = cloud3;
                }
                if (cur == 4)
                {
                    currentcloud = cloud4;
                }
                Vector2 posi = new Vector2(Random.Range(-9, 9), 10);
                Instantiate(currentcloud, posi, Quaternion.identity);
                StartCoroutine(CWait());
            }
        }
        if (starspawned == false)
        {
            Vector2 posi = new Vector2(Random.Range(-9, 9), 6f);
            Instantiate(star, posi, Quaternion.identity);
            StartCoroutine(SWait());
        }
        if (scorewait == true)
        {
            scoretext.text = score.ToString();
            score = score + 1;
            StartCoroutine(secwait());
        }       
    }
}
