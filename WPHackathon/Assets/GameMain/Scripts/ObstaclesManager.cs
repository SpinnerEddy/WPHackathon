using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesManager : MonoBehaviour
{

    [SerializeField] private GameObject[] _obstacle;

    [SerializeField] private MainManager mainManager;

    [SerializeField] private GameObject plane;


    // Use this for initialization
    void Start ()
	{
	    StartCoroutine(CriateObstacle());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator CriateObstacle()
    {
        while (!mainManager.GetIsReady())
        {
            yield return null;
        }

        while (true)
        {
            
            if (Random.value > 0.6)
            {
                int index = (int)Random.Range(0, _obstacle.Length);
                Instantiate(_obstacle[index], new Vector3(plane.transform.position.x + Random.Range(-40, 40), plane.transform.position.y + Random.Range(-13, 1), 150), _obstacle[index].transform.rotation);
                //Instantiate(_obstacle, new Vector3(Random.Range(-40, 40), plane.transform.position.y + Random.Range(-2, 2), 40), this.transform.rotation);
            }
            yield return new WaitForSeconds(0.2f);
        }
    }
}
