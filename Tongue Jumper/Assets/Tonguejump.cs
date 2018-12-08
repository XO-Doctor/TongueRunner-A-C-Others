using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tonguejump : MonoBehaviour {

    public GameObject player;
    public bool holding;
    public Vector3 playerpos;
    public FixedJoint2D joint;
    public Collider2D col;
    public float distance;
    public GameObject tongue;
    public float distancefromy;
    public float distancefromx;
    public Camera cam;
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
        distance = Vector3.Distance(transform.position, player.transform.position);
        tongue.transform.localScale = new Vector3 (distance * 5, 1, 1);
        distancefromx = (transform.position.x + player.transform.position.x);
        distancefromy = (transform.position.y + player.transform.position.y);
        tongue.transform.position = new Vector3(distancefromx /2, distancefromy / 2, 0);
        Vector2 directiont = tongue.transform.position - transform.position;
        float anglet = Mathf.Atan2(directiont.y, directiont.x) * Mathf.Rad2Deg;
        Quaternion rotationt = Quaternion.AngleAxis(anglet, Vector3.forward);
        tongue.transform.rotation = Quaternion.Slerp(transform.rotation, rotationt, 10000 * Time.deltaTime);
        cam.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -30);
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
