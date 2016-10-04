using UnityEngine;
using System.Collections;

public class moveMove : MonoBehaviour {

	float acceleration = 5;
	Rigidbody thisRB;

	// Use this for initialization
	void Start () {
		
		thisRB = GetComponent<Rigidbody> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		thisRB.AddForce (Vector3.right * Input.GetAxis ("Horizontal") * acceleration);
		thisRB.AddForce (Vector3.up * Input.GetAxis ("Vertical") * acceleration);
	}
}
