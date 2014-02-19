using UnityEngine;
using System.Collections;

public class LocationController : MonoBehaviour {
	float x;
	float z;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		x = Random.Range (0f,50f);
		z = Random.Range (0f,50f);
		transform.position = new Vector3 (x,0f,z);
	}
}
