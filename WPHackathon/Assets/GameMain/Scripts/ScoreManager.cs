using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    private float _distants;
    private float _height;

    public UnityEngine.UI.Text Height;
    public UnityEngine.UI.Text Distants;

    // Use this for initialization
    public void Start ()
    {
        _distants = 0;
        _height = 1000;
    }
	
	// Update is called once per frame
	void Update ()
	{
	    Height.text = _height.ToString(CultureInfo.InvariantCulture);
	    Distants.text = _distants.ToString(CultureInfo.InvariantCulture);
        Debug.Log(Distants.text);
	}

    void HeightUpDwon(float d)
    {
        _height -= d;

    }
}
