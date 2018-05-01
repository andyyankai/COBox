using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water_trigger : MonoBehaviour {

	public GameObject boat;
	public GameObject water;

	private bool triggered;
	private float range;
	private float start_y;
	private float end_y;

	// Use this for initialization
	void Start () {
		triggered = false;
		range = 2;
		start_y = water.transform.position.y;
		end_y = start_y - range;

	}
	
	// Update is called once per frame
	void Update () {
		if (triggered) {
			if (water.transform.position.y >= end_y) {
				water.transform.Translate (0, Time.deltaTime * -1, 0);
				boat.transform.Translate (0, Time.deltaTime * -1, 0);
			}
			if(transform.position.y > -0.24){
				transform.Translate (0, Time.deltaTime * -1, 0);
			}
		}
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "switch_trigger") {
			triggered = true;
			Debug.Log ("#####");
		}
	}
}
