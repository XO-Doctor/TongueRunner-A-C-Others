using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tonguejump : MonoBehaviour {

    public GameObject player;
    public bool holding;
    public Vector3 playerpos;
    public FixedJoint2D joint;
    public Collider2D col;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, 10000 * Time.deltaTime);
        playerpos = player.transform.position;

        if (Input.GetMouseButtonDown(0))
        {
            holding = true;
            joint.enabled = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            holding = false;
            joint.enabled = false;
        }
        if (holding == true)
        {
            transform.position += transform.right * Time.deltaTime * 10;
            col.enabled = true;
        }
        if (holding == false)
        {
            transform.position = playerpos;
            col.enabled = false;
        }
    }
}
