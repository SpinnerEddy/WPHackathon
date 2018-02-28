using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selector : MonoBehaviour {
    public GameObject Cursole;

    public void selectPlane(int num)
    {
        SelectedPlane.selectedID = num;
    }

    public void moveCursole(Transform t)
    {
        Cursole.transform.position = t.position;
    }
}
