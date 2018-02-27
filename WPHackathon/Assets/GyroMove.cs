using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroMove : MonoBehaviour {

    /// <summary>
    /// 物体の移動スピード
    /// </summary>
    private float speed;

    /// <summary>
    /// 方向ペクトル
    /// </summary>
    private Vector3 direct;

    /// <summary>
    /// 対象のRigidbody
    /// </summary>
    private Rigidbody body;

    /// <summary>
    /// 機体の角度
    /// </summary>
    private float turnAngle;

	// Use this for initialization
	void Start () {
        speed = 30.0f;
        direct = new Vector3();  //初期化
        body = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        direct = Vector3.zero;  //初期化

        direct.x = Mathf.Clamp(Input.acceleration.x,-1,1);  //ジャイロセンサーの情報を取得
        turnAngle = 20 * Mathf.Clamp(Input.acceleration.x, -1, 1);  //ジャイロセンサーの情報を取得
        //direct.z = Input.acceleration.z;

        if(direct.sqrMagnitude > 1){
            direct.Normalize();  //正規化
        }

        body.AddForce(direct*speed);  //力を加える

        this.transform.rotation = Quaternion.Euler(0, 180, turnAngle);
        //Debug.Log("X : " + direct.x);  //デバッグ
	}
}
