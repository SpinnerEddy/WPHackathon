using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //this.transform.position = new Vector3(Random.Range(-40, 40),0,40);
	}
	
	// Update is called once per frame
	void Update ()
	{
	    transform.position += new Vector3(0,0,-1);
	}

    private void OnTriggerEnter(Collider other)
    {
        //other.transform.GetComponent<きたい>();
        //heightの減少、または増加
        //

        //Debug.Log(other.gameObject.tag);
        //if (other.gameObject.tag == "Fence")
        //{
        //    Destroy(this.gameObject);
        //}

    }
}
