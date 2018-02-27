using UnityEngine;
using System.Collections;

public class AirPlane : MonoBehaviour {

	private float speed = -0.3f;    //これを追加

	// Use this for initialization
	void Start () {
		//以下を追加

		this.GetComponent<Rigidbody>().AddForce(
			(transform.forward + transform.right) * speed,
			ForceMode.VelocityChange);


	}

	// Update is called once per frame
	void Update () {

	}
}