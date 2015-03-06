using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {

    //Left is 0, right is 1
    public bool direction;
    public static float detectionRadius;

	// Use this for initialization
	void Start () {
        detectionRadius = 0.2f;
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log("Begin Update");
        if (!direction)
        {
            Debug.Log("Go left");
            Vector2 overlapSpherePosition = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y) - new Vector2(0.8f, 0.65f);
            Collider2D hitColliders = Physics2D.OverlapCircle(overlapSpherePosition, detectionRadius);
            Debug.Log(hitColliders);
            if (hitColliders == null)
            {
                Debug.Log("Nothing detected");
                direction = !direction;
            }
            else
            {
                Debug.Log("Move left");
                transform.Translate(new Vector2(-0.1f, 0));
            }
        }
        else
        {
            Debug.Log("Go right");
            Vector3 overlapSpherePosition = gameObject.transform.position - new Vector3(-0.8f, 0.65f, 0f);
            Collider2D hitColliders = Physics2D.OverlapCircle(overlapSpherePosition, detectionRadius);
            Debug.Log(hitColliders);
            if (hitColliders == null)
            {
                Debug.Log("Nothing detected");
                direction = !direction;
            }
            else
            {
                Debug.Log("Move right");
                transform.Translate(new Vector2(0.1f, 0));
            }
        }
	}

    private void OnDrawGizmosSelected() {
        Gizmos.color = Color.red;
        //Use the same vars you use to draw your Overlap SPhere to draw your Wire Sphere.
        Gizmos.DrawWireSphere(gameObject.transform.position - new Vector3(0.8f, 0.65f, 0f), detectionRadius);
    }


}
