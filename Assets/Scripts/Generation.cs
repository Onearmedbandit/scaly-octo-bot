using UnityEngine;
using System.Collections;

public class Generation : MonoBehaviour {
	public GameObject treeOne;
	public GameObject treeTwo;
	public GameObject bush;
	public GameObject bear;
	public GameObject flower;
	public Transform masterSpawn;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (Time.time < 120f){


			float randomNumber = Random.Range (0f,100f);
			if (randomNumber < 26) {
				GameObject go = Instantiate (treeOne,masterSpawn.transform.position, Quaternion.identity) as GameObject;
			}
			else if (randomNumber < 51 && randomNumber > 25) {
				GameObject go = Instantiate (treeTwo,masterSpawn.transform.position, Quaternion.Euler (-90f,0f,0f)) as GameObject;
			}
			else if (randomNumber < 71 && randomNumber > 50) {
				GameObject go = Instantiate (bush,masterSpawn.transform.position, Quaternion.identity) as GameObject;
			}
			else if (randomNumber < 91 && randomNumber > 70) {
				GameObject go = Instantiate (bear,masterSpawn.transform.position, Quaternion.identity) as GameObject;
			}
			else if (randomNumber < 101 && randomNumber > 90) {
				GameObject go = Instantiate (flower,masterSpawn.transform.position, Quaternion.identity) as GameObject;
			}
		}
	}
}
