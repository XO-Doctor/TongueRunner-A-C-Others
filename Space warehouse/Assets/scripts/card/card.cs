using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "card/base")]
public class card : ScriptableObject {

    public new string name;
    public string desc;
    public int id;
    public int singleid;
    public GameObject part;
    public int type;
    public int singlewingid;
    public int singleweaponid;
}
