using UnityEngine;
using System.Collections;

public class EnemyGenerator : MonoBehaviour {
	
	public GameObject platformPrefab;
	public bool generatePlatform;
	
    // Use this for initialization
    void Start () {
    
    }
    
    // Update is called once per frame
    void Update () {
		if(generatePlatform)
		{
            float qaz = GameObject.Find("Player").transform.position.x + Random.Range(1f, 3f);
            float wsx = Random.Range(1f,10f);
            Vector3 edc = new Vector3(qaz, wsx, 0f);
			Instantiate(platformPrefab, edc, Quaternion.identity);
		}
	}
}