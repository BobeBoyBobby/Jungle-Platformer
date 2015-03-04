using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {

    //Left is 0, right is 1
    public bool direction;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (!direction)
        {
            Collider[] hitColliders = Physics.OverlapSphere(gameObject.transform.position - new Vector3(0.2f, 0f, 0f), 0.2f);
            if (hitColliders == null || hitColliders.Length == 0)
            {

            }
            else
            {
                transform.Translate(new Vector2(-0.2f, 0));
            }
            Debug.Log(hitColliders.ToString());
        }
        else
        {
            Collider[] hitColliders = Physics.OverlapSphere(gameObject.transform.position - new Vector3(-0.2f, 0f, 0f), 0.2f);
            if (hitColliders == null || hitColliders.Length == 0)
            {

            }
            else
            {
                transform.Translate(new Vector2(0.2f, 0));
            }
            Debug.Log(hitColliders.ToString());
        }
	}
}
