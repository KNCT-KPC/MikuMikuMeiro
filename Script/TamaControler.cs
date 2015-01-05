using UnityEngine;
using System.Collections;

public class TamaControler : MonoBehaviour {

	public static bool flag;

	// Use this for initialization
	void Start () {
		flag = false;
	}
	
	// Update is called once per frame
	void Update () {
		//transform.Translate (0, -Time.deltaTime, 0);
		if (transform.position.y <= 0) {
			Destroy(gameObject);
		}
	}

	void OnCollisionEnter(Collision other) {
		if (other.gameObject.tag == "Player") {
			flag = true;
		}
		Destroy (other.gameObject);
	}
}
