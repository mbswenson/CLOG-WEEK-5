using UnityEngine;
using System.Collections;

public class interpolatorExtreme : MonoBehaviour {

	public Transform pointA;
	public Transform pointB;

	public float percent = 0;

	public float numberOfSeconds = 3;
	// Use this for initialization
	void Start () {
		//pointA = GameObject.Find ("pointA").transform ((this line does the same thing but dynamically?))
	
	}
	
	// Update is called once per frame

	void Update () {
		//set position for the cube as an interpolation between the two points
		transform.position = Vector3.Lerp (pointA.position, pointB.position, percent);
		//percent = percent + (1/60f);
		//Time.deltaTime is the amount of change between this frame and the last one
		percent = percent + Time.deltaTime;
		if (percent > 1) {
			percent = 0;
		//it will adjust no matter the location to make it so that it moves at the speed of one second

			}

		GetComponent<Renderer> ().material.color = Color.Lerp (Color.red, Color.blue, percent);
	}
}
