using UnityEngine;
using System.Collections;

public class Missile : MonoBehaviour {

    private float speed;
    public GameObject explision;

	// Update is called once per frame
	void Update () {
        speed = Random.Range(0.3f, 0.7f);
        transform.localPosition += transform.forward * speed;
	}

    void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag == "Player")
        {
            //Destroy(gameObject);
            Destroy(this.gameObject);
            Instantiate(explision, transform.position, Quaternion.identity);
        }
    }
}
