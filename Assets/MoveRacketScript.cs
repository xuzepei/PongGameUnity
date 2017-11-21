using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRacketScript : MonoBehaviour {

	public float speed = 30;

//	// Use this for initialization
//	void Start () {
//		
//	}
//	
//	// Update is called once per frame
//	void Update () {
//		print ("----Update");
//	}

	void FixedUpdate () {

		print ("----FixedUpdate");

		float v = Input.GetAxisRaw ("Vertical");
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, v) * speed;

	
	}
}
