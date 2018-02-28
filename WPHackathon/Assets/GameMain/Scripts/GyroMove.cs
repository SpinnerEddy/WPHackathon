﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroMove : MonoBehaviour {

    /// <summary>
    /// 物体の移動スピード(旋回)
    /// </summary>
    private float speed;

    /// <summary>
    /// 前進速度(スコアに反映)
    /// </summary>
    private float progressSpeed;

    /// <summary>
    /// カメラ
    /// </summary>
    [SerializeField]
    private GameObject camera;

    /// <summary>
    /// 高度
    /// </summary>
    private float height;
    public float Height
    {
        get
        {
            return height;
        }

        private set
        {
            height = value;
        }
    }

    /// <summary>
    /// 飛距離
    /// </summary>
    private float flyingDistance;
    public float FlyingDistance
    {
        get
        {
            return flyingDistance;
        }

        private set
        {
            flyingDistance = value;
        }
    }


    /// <summary>
    /// 浮力(高度の落ちやすさ)
    /// </summary>
    private Vector3 buoyancy;

    /// <summary>
    /// 頑丈さ(ぶつかった時の落下距離)
    /// </summary>
    private float sturdy;

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

    /// <summary>
    /// The x off of PerlineNoise.
    /// </summary>
    private float xOff;

    /// <summary>
    /// The y off of PerlineNoise.
    /// </summary>
    private float yOff;


    // Use this for initialization
    void Start()
    {
        buoyancy = new Vector3(0,0.02f,0);
        sturdy = 10f;
        speed = 30.0f;
        direct = new Vector3();  //初期化
        body = GetComponent<Rigidbody>();
        turnAngle = 0f;
        xOff = Random.Range(0, 10000);
        yOff = Random.Range(0, 10000);
        flyingDistance = 0;
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



        this.transform.rotation = Quaternion.Euler(-10 + 20 * Mathf.PerlinNoise(xOff, yOff), 180f, turnAngle-1+2*Mathf.PerlinNoise(yOff, xOff));

        this.transform.position -= buoyancy;

        height = this.transform.position.y;  //高度はy座標

        flyingDistance += 2;  //飛距離

        xOff += 0.01f;
        yOff += 0.01f;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Obstacle"){
            body.AddForce(new Vector3(0,-5,0));
        }
    }

    private void damageCameraShake(){
        float amp = 20;
        float theta = 0;
        while(amp >= 0){
            camera.transform.rotation = Quaternion.Euler(0,0, amp * Mathf.Sin(theta));
            theta++;
            amp -= 0.5f;
        }
    }

}
