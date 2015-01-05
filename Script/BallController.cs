using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {
	
	public float degree = 0f;
	public float speed = 100f;
	// Use this for initialization
	void Start () {
		//shotBall ();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = Vector3.zero;
		pos.x = Mathf.Sin(Time.time) * 5;
		pos.y = -3;
		transform.position = pos; 
	}
	
	void shotBall() {
		Vector3 vel = Vector3.zero;
		vel.x = speed;
		rigidbody.velocity = vel * 3;
	}
}
