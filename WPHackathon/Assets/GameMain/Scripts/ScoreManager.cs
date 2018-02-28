using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private GyroMove AirPlane;
    [SerializeField] private MainManager _mainManager;

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
    void Update()
    {

        if (_mainManager.GetIsGameOver())
        {
            Height.text = "0";
            return;
        }

        _distants = AirPlane.FlyingDistance;
	    _height = AirPlane.Height;

	    Height.text = _height.ToString(CultureInfo.InvariantCulture);
	    Distants.text = _distants.ToString(CultureInfo.InvariantCulture);

        if (!_mainManager.GetIsReady())
        {
            Distants.text = "0";
        }
	}

    void HeightUpDwon(float d)
    {
        _height -= d;

    }

    public float GetHeight()
    {
        return _height;
    }

    public float GetDistants()
    {
        return _distants;
    }
}
