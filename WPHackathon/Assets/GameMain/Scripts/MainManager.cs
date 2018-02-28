using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;

public class MainManager : MonoBehaviour
{
    private bool _isReady;
    private bool _isGameOver;


    [SerializeField] private UnityEngine.UI.Text _countDownText;
    [SerializeField] private GameObject _setumei;

    [SerializeField] private GameObject _gameOverFrame;
    [SerializeField] private UnityEngine.UI.Text _gameOverText;

    [SerializeField] private ScoreManager _scoreManager;



    public bool GetIsReady()
    {
        return _isReady;
    }

    public bool GetIsGameOver()
    {
        return _isGameOver;
    }


    // Use this for initialization
    void Start ()
    {
        _isReady = false;
        _isGameOver = false;
	    StartCoroutine(Ready());
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (_scoreManager.GetHeight() <= 0)
        {
            _isGameOver = true;
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
        _gameOverText.text = _scoreManager.GetDistants().ToString() + "m";

        while (!Input.GetMouseButton(0) && Input.touchCount == 0)
        {
            yield return null;
        }
        SceneManager.LoadScene("Title");

    }
}
