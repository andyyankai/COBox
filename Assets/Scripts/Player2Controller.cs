using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour {

    public float moveSpeed = 5;
    public GameObject partner;
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

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(-1 * moveSpeed * Time.deltaTime, 0f, 0f));
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(1 * moveSpeed * Time.deltaTime, 0f, 0f));
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (GM.sizeRatio + 1 <= 3)
            {
                transform.Translate(new Vector3(0f, 1.25f * moveSpeed * Time.deltaTime, 0f));
            }
            else
            {
                transform.Translate(new Vector3(0f, 2f * moveSpeed * Time.deltaTime, 0f));
            }
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0f, -1 * moveSpeed * Time.deltaTime, 0f));
        }


        //change Size
        if (Input.GetKeyDown(KeyCode.Minus))
        {
            var x = gameObject.transform.localScale.x;
            var y = gameObject.transform.localScale.y;
            var x2 = partner.gameObject.transform.localScale.x;
            var y2 = partner.gameObject.transform.localScale.y;

            if (GM.sizeRatio + 1 <= 4)
            {
                GM.sizeRatio += 2;
                gameObject.transform.localScale = new Vector3(x / 1.5f, y / 1.5f, 1f);
                partner.gameObject.transform.localScale = new Vector3(x2 * 1.5f, y2 * 1.5f, 1f);
            }
        }

        if (Input.GetKeyDown(KeyCode.Equals))
        {
            var x = gameObject.transform.localScale.x;
            var y = gameObject.transform.localScale.y;
            var x2 = partner.gameObject.transform.localScale.x;
            var y2 = partner.gameObject.transform.localScale.y;

            if (GM.sizeRatio - 1 >= 2)
            {
                GM.sizeRatio -= 2;
                gameObject.transform.localScale = new Vector3(x * 1.5f, y * 1.5f, 1f);
                partner.gameObject.transform.localScale = new Vector3(x2 / 1.5f, y2 / 1.5f, 1f);
            }
        }


    }
}
