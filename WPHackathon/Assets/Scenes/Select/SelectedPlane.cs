using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedPlane : MonoBehaviour {
    public static int selectedID = -1;

	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(this);
    }
    public static void selectPlane(int num)
    {
        selectedID = num;
    }
	
}
