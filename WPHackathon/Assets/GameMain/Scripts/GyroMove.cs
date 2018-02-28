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
    /// 旋回時の傾き
    /// </summary>
    private float turnAngle;

    // Use this for initialization
    void Start()
    {
        speed = 30.0f;
        direct = new Vector3();  //初期化
        body = GetComponent<Rigidbody>();
        turnAngle = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        direct = Vector3.zero;  //初期化

        direct.x = Mathf.Clamp(Input.acceleration.x,-1,1);  //ジャイロセンサーの情報を取得
        //direct.z = Input.acceleration.z;
        turnAngle = 30 * direct.x;

        if (direct.sqrMagnitude > 1)
        {
            direct.Normalize();  //正規化
        }

        body.AddForce(direct * speed);  //力を加える

        //Debug.Log("X : " + direct.x);  //デバッグ

        this.transform.rotation = Quaternion.Euler(0f, 180f, turnAngle);
    }

}
