using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cardlist : MonoBehaviour {

    public card Caard;
    public Outcome outcome;
    public card c1;
    public card c2;
    public card c3;
    public card c4;
    public int listnum;
    public List<card> cardes = new List<card>();

    // Update is called once per frame

    public void Start()
    {
        
    }

    void Update () {

        if (outcome.ids.Count != listnum - 1)
        {
            listnum = listnum + 1;
        }
        else { 
}

        if(outcome.ids[listnum - 1] == 112212)
        {
            cardes.Add(c1);
        }
        if (outcome.ids[listnum - 1] == 111222)
        {
            cardes.Add(c2);
        }
        if (outcome.ids[listnum - 1] == 111111)
        {
            cardes.Add(c3);
        }
        if (outcome.ids[listnum - 1] == 234432)
        {
            cardes.Add(c4);
        }
    }
}
