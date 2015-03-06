using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	
	public bool grounded;
    public Rigidbody2D rigidbody;

    // Use this for initialization
    void Start () {
        rigidbody = GetComponent<Rigidbody2D>();
    }
    
    // Update is called once per frame
    void Update () {
    	if (Input.GetKey ("space") || Input.GetKey ("w") || Input.GetKey ("up"))
		{
			if(grounded){
				rigidbody.AddForce(new Vector2(0f, 10f), ForceMode2D.Impulse);
				grounded = false;
			}
		}
		if (Input.GetKey ("a") || Input.GetKey ("left"))
		{
			transform.Translate(new Vector2(-0.2f, 0));
		}
		if (Input.GetKey ("s") || Input.GetKey ("down"))
		{
			if(!grounded){
                rigidbody.AddForce(new Vector2(0f, -20f), ForceMode2D.Impulse);
				grounded = true;
			}
		}
		if (Input.GetKey ("d") || Input.GetKey ("right"))
		{
			transform.Translate(new Vector2(0.2f, 0));
		}
	}
	
	void OnCollisionEnter2D (Collision2D col) {
		grounded = true;
        if (col.gameObject.tag == "enemy")
        {
            if (gameObject.transform.position.y > col.gameObject.transform.position.y)
            {
                Destroy(col.gameObject);
            }
            else
            {
                GameManager.Respawn();
            }
        }
	}

	void OnCollisionExit2D () {
		grounded = false;
	}
}


//BobeBoyBobby

