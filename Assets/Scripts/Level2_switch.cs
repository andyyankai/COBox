using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2_switch : MonoBehaviour {


	public GameObject f1;
	public GameObject f2;
	public GameObject f3;
	public float speed;
	public GameObject second_switch;
	public int floor_State;

	private bool triggered = false;
	private bool reverse = false;
	private bool switch_pos = true;
	private bool f1_pos = false;
	private bool f2_pos = false;
	private bool f3_pos = false;
	private Level2_switch l2switch;

	void Start()
	{
		l2switch = second_switch.GetComponent<Level2_switch> ();
	}
	void Update()
	{
		if (triggered) {
			if (floor_State == 0 || floor_State == 3) {
				if (f1.transform.position.y < -4.0) { //floor1_movement
					f1.transform.Translate (0, Time.deltaTime * 1, 0);
				} else {
					f1_pos = true;
				}
				if (f3.transform.position.y > -6.5) { //floor3_movement
					f3.transform.Translate (0, Time.deltaTime * -1, 0);
				} else {
					f3_pos = true;
				}
				if (transform.position.y > -4.2)//switch_movement
				transform.Translate (0, -1 * Time.deltaTime, 0);
				else {
					switch_pos = false;
				}
				if (f1_pos && f3_pos && !switch_pos) {
					triggered = false;
					reverse = true;
					floor_State = l2switch.floor_State = 1;

				}
			} else if (floor_State == 1) {
				if (f1.transform.position.y > -6.5) { //floor1_movement
					f1.transform.Translate (0, Time.deltaTime * -1, 0);
				} else {
					f1_pos = false;
				}
				if (f2.transform.position.y <= -4.0) {
					f2.transform.Translate (0, Time.deltaTime * 1, 0);
				} else {
					f2_pos = true;
				}
				if (transform.position.y > -4.2)//switch_movement
					transform.Translate (0, -1 * Time.deltaTime, 0);
				else {
					switch_pos = false;
				}
				if (!f1_pos && f2_pos && !switch_pos) {
					triggered = false;
					reverse = true;
					floor_State = l2switch.floor_State = 2;
				}

			} else if (floor_State == 2) {
				if (f2.transform.position.y > -6.5) { //floor1_movement
					f2.transform.Translate (0, Time.deltaTime * -1, 0);
				} else {
					f2_pos = false;
				}
				if (f3.transform.position.y <= -4.0) {
					f3.transform.Translate (0, Time.deltaTime * 1, 0);
				} else {
					f3_pos = true;
				}
				if (transform.position.y > -4.2)//switch_movement
					transform.Translate (0, -1 * Time.deltaTime, 0);
				else {
					switch_pos = false;
				}
				if (!f2_pos && f3_pos && !switch_pos) {
					triggered = false;
					reverse = true;
					floor_State = l2switch.floor_State = 3;
				}

			}

		}
		else if (reverse && transform.position.y < - 3.6) 
		{
			transform.Translate (0,  1 * Time.deltaTime, 0);//switch_movement
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag == "switch_trigger") {
			Debug.Log (f1.transform.position.y);
			Debug.Log (transform.position.y);
			triggered = true;
			reverse = false;
			Debug.Log ("!!!");
		}
	}

	void OnTriggerStay2D(Collider2D other)
	{
		
	}
	void OnTriggerExit2D(Collider2D other)
	{

	}

}
