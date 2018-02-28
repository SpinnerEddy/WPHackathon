using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubObstacleManager : MonoBehaviour {

    [SerializeField] private GameObject[] _obstacle;

    [SerializeField] private GameObject plane;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(CriateObstacle());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator CriateObstacle()
    {
        while (true)
        {

            if (Random.value > 0.7)
            {
                int index = (int)Random.Range(0,_obstacle.Length);
                Instantiate(_obstacle[index],new Vector3(plane.transform.position.x + Random.Range(-40, 40), plane.transform.position.y+Random.Range(-2, 2), 200),_obstacle[index].transform.rotation);
                //Instantiate(_obstacle, plane.transform.position, this.transform.rotation);
            }
            yield return new WaitForSeconds(0.2f);
        }
    }
}
