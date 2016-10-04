using UnityEngine;
using System.Collections;

public class lureDrop : MonoBehaviour {
	public Transform pointA;
	public Transform pointB;

	public float percent = 0;

	public float numberOfSeconds = 10;
	public float direction = -1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
			if (Input.GetKey (KeyCode.Space) == true) {
			transform.position = Vector3.Lerp (pointA.position, pointB.position, percent);
			percent += Time.deltaTime / numberOfSeconds * direction;
			if (percent > 1) {
				direction = -1;
			}

			if (percent < 0) {
				direction = 1;

			}
		}
	
	}
}
