using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {
	public GameObject player1;
	public GameObject player2;
	public Vector3 offset;

	// Use this for initialization
	void Start () {

        offset = transform.position - (player1.transform.position + player2.transform.position)/2;

    }
	
	// Update is called once per frame
	void Update () {
        //float x = Mathf.Abs(player1.transform.position.x + player2.transform.position.x) / 2f;
        Vector3 p1Position = player1.transform.position;
        float xp1 = p1Position.x;
        //float xp1 = p1Position.x;
        //float xp1 = p1Position.x;

        Vector3 p2Position = player2.transform.position;
        float xp2 = p2Position.x;
        //float xp2 = p2Position.x;
        //float xp2 = p2Position.x;

        Vector3 horizontalP1Position = new Vector3(xp1, 0, p1Position.z);
        Vector3 horizontalP2Position=new Vector3(xp2, 0, p2Position.z);

        transform.position = (horizontalP1Position + horizontalP2Position) /2 + offset;
	}
}






















