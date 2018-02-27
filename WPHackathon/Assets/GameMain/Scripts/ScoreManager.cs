using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{

    private float _distants;
    private float _height;

    // Use this for initialization
    public void Start ()
    {
        _distants = 0;
        _height = 1000;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void HeightUpDwon(float d)
    {
        _height -= d;

    }
}
