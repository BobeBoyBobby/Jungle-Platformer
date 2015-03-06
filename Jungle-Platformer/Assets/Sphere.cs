using UnityEngine;
using System.Collections;

public class Sphere : MonoBehaviour {

    int a;

	// Use this for initialization
	void Start () {
        transform.transform.localScale = new Vector3(EnemyAI.detectionRadius, EnemyAI.detectionRadius);
	}
	
	// Update is called once per frame
	void Update () {
        if (a < 10)
        {
            a++;
        }
        else
        {
            Destroy(gameObject);
        }
	}
}
