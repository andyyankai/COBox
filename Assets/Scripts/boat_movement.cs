using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boat_movement : MonoBehaviour {

	public GameObject boat;
	public float speed;

	private bool move_forward;
	private float move_range;
	private float start_x;
	private float end_x;
	private bool triggered;

	private Vector3 tempos;

	// Use this for initialization
	void Start () {
		move_forward = true;
		triggered = false;
		move_range = 20;
		start_x = boat.transform.position.x;
		end_x = start_x + move_range;
	}
	
	// Update is called once per frame
	void Update () {
		if (triggered) {
			if (move_forward) {
				if (boat.transform.position.x <= end_x) {
					boat.transform.Translate (Time.deltaTime * speed, 0, 0);
					tempos = boat.transform.position;
					tempos.y += Mathf.Sin (Time.fixedTime * Mathf.PI * 1) * 0.01f;
					boat.transform.position = tempos;
				} else
					move_forward = false;
			} else {
				if (boat.transform.position.x >= start_x) {
					boat.transform.Translate (Time.deltaTime * -speed, 0, 0);
					tempos = boat.transform.position;
					tempos.y += Mathf.Sin (Time.fixedTime * Mathf.PI * 1) * 0.01f;
					boat.transform.position = tempos;
				} else
					move_forward = true;
			}
			if(transform.position.y > -1.5){
				transform.Translate (0, Time.deltaTime * -1, 0);
			}
		}
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "switch_trigger") {
			triggered = true;
			Debug.Log ("!!!!!");
		}
	}
}
