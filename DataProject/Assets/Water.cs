using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour {

	private float speed = 10.0f;
	// Use this for initialization
	void Start () {
		transform.position = new Vector3 (0, 0, 0);
	}
	float dicks = 0.0f;
	// Update is called once per frame
	void Update () {
		dicks += Time.deltaTime * speed;
		transform.Translate (new Vector3 (dicks, dicks, dicks));
	}

}