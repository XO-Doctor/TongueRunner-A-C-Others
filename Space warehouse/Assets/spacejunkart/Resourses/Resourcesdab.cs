using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resourcesdab : MonoBehaviour
{ 
    public int wooda;
    public int nutsa;
    public int steela;
    public int batterya;
    public GameObject items;
    private bool spawned = false;
    public Saving save;

    private void Start()
    {
        wooda = PlayerPrefs.GetInt("SavedWoods");
        steela = PlayerPrefs.GetInt("SavedMetals");
        batterya = PlayerPrefs.GetInt("SavedBatteries");
        nutsa = PlayerPrefs.GetInt("SavedNuts");
    }

    public void Update()
    {
        PlayerPrefs.SetInt("SavedWoods", wooda);
        PlayerPrefs.SetInt("SavedMetals", steela);
        PlayerPrefs.SetInt("SavedBatteries", batterya);
        PlayerPrefs.SetInt("SavedNuts", nutsa);
        if (spawned == false)
        {
            Vector2 posi = new Vector2(Random.Range(-9, 9), 10);
            Instantiate(items, posi, Quaternion.identity);
            StartCoroutine(Wait());
        }

    }

    IEnumerator Wait()
    {
        spawned = true;
        yield return new WaitForSeconds(Random.Range(3f, 6f));
        spawned = false;
    }

}
