using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMoveGyro : MonoBehaviour {

    private float speed;

    private Vector3 direct;

    private Rigidbody body;

	// Use this for initialization
	void Start () {
        speed = 10.0f;
        direct = new Vector3();
        body = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        direct = Vector3.zero;

        direct.x = Input.acceleration.x;
        //direct.z = Input.acceleration.z;

        if(direct.sqrMagnitude > 1){
            direct.Normalize();
        }

        //direct *= Time.deltaTime;

        //this.transform.Translate(direct * speed);

        body.AddForce(direct*30);

        Debug.Log("X : " + direct.x);
        //Debug.Log("Z : " + direct.z);
	}
}
