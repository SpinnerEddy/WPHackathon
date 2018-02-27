using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour {

    [SerializeField]
    private GameObject following;

    private Vector3 cameraPosition;

	// Use this for initialization
	void Start () {
        cameraPosition = new Vector3(0, 1, -10);
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position = following.transform.position + cameraPosition;
	}
}
