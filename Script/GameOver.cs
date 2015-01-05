using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {
	
	GameObject miku;

	// Use this for initialization
	void Start () {
		guiText.enabled = false;
		miku = GameObject.Find("miku");
	}
	
	// Update is called once per frame
	void Update () {
		if (TamaControler.flag || miku.transform.position.y <= -5) {
			guiText.enabled = true;
			if (Input.GetKeyDown(KeyCode.Space)) {
				Application.LoadLevel("Main");
			}
		}
	}
}
