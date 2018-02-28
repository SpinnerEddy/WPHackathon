using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainManager : MonoBehaviour
{


    [SerializeField] private Text _countDownText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator Ready()
    {
        //最初の説明ポップちゅう
        while (!Input.GetMouseButton(0) && Input.touchCount == 0)
        {
            yield return null;
        }

        _countDownText.text = "3";

        yield return new WaitForSeconds(2f);
    }
}
