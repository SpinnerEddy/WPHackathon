using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverFrame : MonoBehaviour
{
    private Image me;

	// Use this for initialization
	void Start ()
	{
	    me = gameObject.GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {

	}

    IEnumerator pop()
    {
        for (int i = 0; i < 10; i++)
        {
            //gameObject.scale += 0.1f;
            
        }
        yield return null;
    }
}
