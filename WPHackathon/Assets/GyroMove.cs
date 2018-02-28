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

    // Use this for initialization
    void Start()
    {
        speed = 30.0f;
        direct = new Vector3();  //初期化
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        direct = Vector3.zero;  //初期化

        direct.x = Input.acceleration.x;  //ジャイロセンサーの情報を取得
        //direct.z = Input.acceleration.z;

        if (direct.sqrMagnitude > 1)
        {
            direct.Normalize();  //正規化
        }

        body.AddForce(direct * speed);  //力を加える

        //Debug.Log("X : " + direct.x);  //デバッグ
    }

}
