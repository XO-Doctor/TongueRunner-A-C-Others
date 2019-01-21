using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteorcontroller : MonoBehaviour {

    public float sizechooser;
    public GameObject me;

	// Use this for initialization
	void Start () {
        sizechooser = Random.Range(1, 6);
        if (sizechooser == 1 || sizechooser == 2 || sizechooser == 3 || sizechooser == 4)
        {

            float size = Random.Range(1f, 3f);
            me.transform.localScale = new Vector3(size, size, 0);

        }
        if (sizechooser == 5)
        {

            float sizes = Random.Range(3.5f, 4.2f);
            me.transform.localScale = new Vector3(sizes, sizes, 0);

        }
    }
    private void Update()
    {
        transform.Rotate(Vector3.forward * Random.Range(2.5f, 4f));
    }
}
