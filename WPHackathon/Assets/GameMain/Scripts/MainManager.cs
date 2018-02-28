using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainManager : MonoBehaviour
{
    private bool _isReady;

    [SerializeField] private Text _countDownText;
    [SerializeField] private GameObject _setumei;

    public bool GetIsReady()
    {
        return _isReady;
    }


    // Use this for initialization
    void Start ()
	{
	    StartCoroutine(Ready());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator Ready()
    {
        _countDownText.text = "";

        //最初の説明ポップちゅう
        while (!Input.GetMouseButton(0) && Input.touchCount == 0)
        {
            yield return null;
        }

        _setumei.SetActive(false);
        _countDownText.text = "3";

        yield return new WaitForSeconds(1f);

        _countDownText.text = "2";

        yield return new WaitForSeconds(1f);

        _countDownText.text = "1";

        yield return new WaitForSeconds(1f);

        _countDownText.text = "GO!";
        _isReady = true;

        yield return new WaitForSeconds(1f);

        _countDownText.text = "";
    }
}
