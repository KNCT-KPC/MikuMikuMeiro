using UnityEngine;
using System.Collections;

public class TamaMaker : MonoBehaviour {

	float timer=0;
	public GameObject TamaPrefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (timer > 2.0) {
			int x, z;
			x = Random.Range(-3, 4);
			z = Random.Range(-3, 4);
			Vector3 pos = new Vector3(x, 5, z);
			Instantiate(TamaPrefab, pos, Quaternion.identity);
			timer = 0;
		}
	}
}
