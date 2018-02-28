using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;

public class MainManager : MonoBehaviour
{
    private bool _isReady;

    [SerializeField] private UnityEngine.UI.Text _countDownText;
    [SerializeField] private GameObject _setumei;

    [SerializeField] private GameObject _gameOverFrame;
    [SerializeField] private UnityEngine.UI.Text _gameOverText;

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
	void Update ()
    {
        if (true /*ゲームオーバーしたら*/)
        {
            StartCoroutine(GameEnd());
        }
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

    IEnumerator GameEnd()
    {
        yield return new WaitForSeconds(1f);


        _gameOverFrame.SetActive(true);
        _gameOverText.text = "ffffm";//すこあ.tostring();

        while (!Input.GetMouseButton(0) && Input.touchCount == 0)
        {
            yield return null;
        }
        SceneManager.LoadScene("Title");

    }
}
