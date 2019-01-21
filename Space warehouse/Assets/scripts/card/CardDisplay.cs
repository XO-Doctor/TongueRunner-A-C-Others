using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    public GameObject part;
    public card Card;
    public Text Name;
    public Text desc;
    public GameObject FakeBase;
    public ship ship;

    private void Start()
    {
        //Name.text = Card.name;
        //desc.text = Card.desc;
        //part = Card.part;  

    }

    public void Update()
    {
        Name.text = Card.name;
        desc.text = Card.desc;
        part = Card.part;
        part = Card.part;
        ship = GameObject.FindObjectOfType<ship>();
    }


    public void onclick()
    {
        if (Card.type == 1)
        {
            Destroy(ship.currentbase);
            Vector3 sades = new Vector3(0, 2, 0);
            ship.currentbase = Instantiate(part, sades, Quaternion.identity, GameObject.FindGameObjectWithTag("baseprefab").transform);
            PlayerPrefs.SetInt("singleid", Card.singleid);
        }
        if (Card.type == 2)
        {
            Destroy(ship.currentwing);
            Vector3 sades = new Vector3(0, 2, 0);
            ship.currentwing = Instantiate(part, sades, Quaternion.identity, GameObject.FindGameObjectWithTag("wingprefab").transform);
            PlayerPrefs.SetInt("singlewingid", Card.singlewingid);
        }
    }

}
