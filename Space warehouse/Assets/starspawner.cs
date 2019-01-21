using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starspawner : MonoBehaviour {

    public GameObject star;
    public Rigidbody2D me;

	// Use this for initialization
	void Start () {
        float size = Random.Range(0.5f, 1.5f);
        star.transform.localScale = new Vector2(size, size);
        me.gravityScale = (size / 75);
        StartCoroutine(Wait());

    }
	
	// Update is called once per frame
	void Update () {
        
    }

    public IEnumerator Wait()
    {
        yield return new WaitForSeconds(20);
        Destroy(gameObject);
    }

}
