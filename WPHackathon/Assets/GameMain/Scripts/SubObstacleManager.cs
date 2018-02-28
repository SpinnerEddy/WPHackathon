using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubObstacleManager : MonoBehaviour {

    [SerializeField] private GameObject _obstacle;

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

            if (Random.value > 0.3)
            {
                Instantiate(_obstacle);
            }
            yield return new WaitForSeconds(0.2f);
        }
    }
}
