using UnityEngine;
using System.Collections;

public class ChangeColor : MonoBehaviour {

	// Use this for initialization
	void Start () {
		float R = Random.value;
		float G = Random.value;
		float B = Random.value;
		float A = Random.value;
		renderer.material.color = new Color (R, G, B, A);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
