using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Controller : MonoBehaviour {

    public float moveSpeed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        /* if(Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f )
        {
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
        }

        if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
        {a
            transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0f));
        }*/

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-1 * moveSpeed * Time.deltaTime, 0f, 0f));
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(1 * moveSpeed * Time.deltaTime, 0f, 0f));
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0f, 1 * moveSpeed * Time.deltaTime, 0f));
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0f, -1 * moveSpeed * Time.deltaTime, 0f));
        }
    }
}
