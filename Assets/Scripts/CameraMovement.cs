using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {
	public GameObject player1;
	public GameObject player2;
	public Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - (player1.transform.position+player2.transform.position)/2;
	}
	
	// Update is called once per frame
	void Update () {
		//float x = Mathf.Abs(player1.transform.position.x + player2.transform.position.x) / 2f;

		transform.position = (player1.transform.position+player2.transform.position)/2 + offset;
	}
}
