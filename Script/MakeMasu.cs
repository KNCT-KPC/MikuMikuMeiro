using UnityEngine;
using System.Collections;

public class MakeMasu : MonoBehaviour {

	int i, j;
	public GameObject Masu;

	// Use this for initialization
	void Start () {
		for (i = -3; i < 4; i++) {
			for (j =  -3; j < 4; j++) {
				GameObject child;
				child = (GameObject)Instantiate(Masu, new Vector3(i, 0, j), Quaternion.identity);
				child.transform.parent = this.transform;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
