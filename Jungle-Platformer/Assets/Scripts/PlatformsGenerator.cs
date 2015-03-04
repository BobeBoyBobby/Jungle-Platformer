using UnityEngine;
using System.Collections;

public class PlatformsGenerator : MonoBehaviour {
	
	public GameObject platformPrefab;
	public bool generatePlatform;
	
    // Use this for initialization
    void Start () {
    
    }
    
    // Update is called once per frame
    void Update () {
		if(generatePlatform)
		{
            Instantiate(platformPrefab, new Vector3(GameObject.Find("Player").transform.position.x + Random.Range(1f, 3f), Random.Range(1f, 10f), 0f), Quaternion.identity);
		}
	}
}


//BobeBoyBobby

