using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloud : MonoBehaviour {

    public Sprite lg1;
    public Sprite lg2;
    public Sprite ls;
    public Sprite l;
    private bool follow;
    public GameObject player;
    public SpriteRenderer sr;
    public GameObject lightning;

    // Use this for initialization
    void Start () {
        follow = true;
        StartCoroutine(Wait());
	}

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(Random.Range(5, 10));
        follow = false;
        sr.sprite = lg1;
        yield return new WaitForSeconds(0.09f);
        sr.sprite = lg2;
        yield return new WaitForSeconds(0.09f);
        sr.sprite = lg1;
        yield return new WaitForSeconds(0.09f);
        sr.sprite = l;
        yield return new WaitForSeconds(1.5f);
        sr.sprite = lg1;
        yield return new WaitForSeconds(0.09f);
        sr.sprite = lg2;
        yield return new WaitForSeconds(0.09f);
        sr.sprite = lg1;
        yield return new WaitForSeconds(0.09f);
        sr.sprite = l;
        yield return new WaitForSeconds(1.5f);
        sr.sprite = lg1;
        yield return new WaitForSeconds(0.09f);
        sr.sprite = lg2;
        yield return new WaitForSeconds(0.09f);
        sr.sprite = lg1;
        yield return new WaitForSeconds(0.09f);
        sr.sprite = l;
        yield return new WaitForSeconds(2f);
        sr.sprite = ls;
        Vector3 offset = new Vector3(player.transform.position.x, 4, 0);
        Instantiate(lightning, offset, Quaternion.identity);
    }

	// Update is called once per frame
	void Update () {
		if (follow)
        {
            Vector3 offset = new Vector3(player.transform.position.x, 4, 0);
            transform.position = offset;
        }
	}
}
