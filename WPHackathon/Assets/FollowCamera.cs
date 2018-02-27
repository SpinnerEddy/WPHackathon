using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour {

    /// <summary>
    /// 追従対象のオブジェクト
    /// </summary>
    [SerializeField]
    private GameObject following;  

    /// <summary>
    /// 追従するときのカメラの位置
    /// </summary>
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
