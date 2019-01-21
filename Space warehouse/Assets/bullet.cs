using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {

    public Rigidbody2D rb;
    public float thrust; 

	// Use this for initialization
	void Start () {
        rb.AddForce(transform.up * thrust);
        StartCoroutine(WAit());
	}
	
    public IEnumerator WAit()
    {
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }

	// Update is called once per frame
	void Update () {
		
	}

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == ("Meteor"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }

}
