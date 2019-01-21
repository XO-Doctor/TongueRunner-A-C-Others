using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipchooser : MonoBehaviour {

    public GameObject Base;
    public GameObject Wing;
    public GameObject s1;
    public GameObject s2;
    public GameObject s3;
    public GameObject s4;
    public GameObject s5;
    public GameObject s6;
    public GameObject sw1;
    public GameObject sw2;
    public GameObject sw3;
    public GameObject sw4;
    public GameObject sw5;
    public GameObject sw6;
    public float yeettest;

    // Use this for initialization
    void Start () {

        yeettest = PlayerPrefs.GetFloat("singlewingid");

        if (PlayerPrefs.GetInt("singleid") == 1)
        {
            Vector3 faf = new Vector3(0, 0, 0);
            Instantiate(s2, faf, Quaternion.identity, Base.transform);
        }
        if (PlayerPrefs.GetInt("singleid") == 2)
        {
            Vector3 faf = new Vector3(0, 0, 0);
            Instantiate(s1, faf, Quaternion.identity, Base.transform);
        }
        if (PlayerPrefs.GetInt("singlewingid") == 1)
        {
            Vector3 faf = new Vector3(0, 0, 0);
            Instantiate(sw1, faf, Quaternion.identity, Wing.transform);
        }
        if (PlayerPrefs.GetInt("singlewingid") == 2)
        {
            Vector3 faf = new Vector3(0, 0, 0);
            Instantiate(sw2, faf, Quaternion.identity, Wing.transform);
        }
    }
	
	// Update is called once per frame
	void Update () {
        
    }
}
