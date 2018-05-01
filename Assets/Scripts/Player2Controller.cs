using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour {

    public float moveSpeed = 5;
    public GameObject partner;
	public Sprite p2_mag;
	public Sprite p2;
    public AudioClip magSound;

    //public float mass;
    //mass:normal=2,small=1,big=3
    public Rigidbody2D rb;

	private bool mg_on = true;
	private float mg_strength;

	private SpriteRenderer spr;


    // Use this for initialization
    void Start () {
		spr = GetComponent<SpriteRenderer> ();
		spr.sprite = p2_mag;
	}
	
	// Update is called once per frame
	void Update () {
        
        //mass:
        if (GM.sizeRatio == 2)
        {
            rb.mass = 1;
        }
        if (GM.sizeRatio == 3)
        {
            rb.mass = 3;
        }

        //move:
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
            if (GM.sizeRatio ==3)
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

		//disable mag
		if (Input.GetKeyDown (KeyCode.Minus)) 
		{
            AudioSource.PlayClipAtPoint(magSound, transform.position);
            if (mg_on) {
				MagneticField_S mf = gameObject.GetComponent<MagneticField_S> ();
				mg_strength = mf.strength;
				mf.strength = 0;
				mg_on = false;
				spr.sprite = p2;
			} else {
				MagneticField_S mf = gameObject.GetComponent<MagneticField_S> ();
				mf.strength = mg_strength;
				mg_on = true;
				spr.sprite = p2_mag;
			}
		}


        //change Size:
        if (Input.GetKeyDown(KeyCode.Equals))
        {
            AudioSource.PlayClipAtPoint(magSound, transform.position);
            var x = gameObject.transform.localScale.x;
            var y = gameObject.transform.localScale.y;
            var x2 = partner.gameObject.transform.localScale.x;
            var y2 = partner.gameObject.transform.localScale.y;

            if (GM.sizeRatio == 3)
            {
                GM.sizeRatio = 2;
                Debug.Log("sizeRatio:" + GM.sizeRatio);
                gameObject.transform.localScale = new Vector3(x / 2.25f, y / 2.25f, 1f);
                partner.gameObject.transform.localScale = new Vector3(x2 * 2.25f, y2 * 2.25f, 1f);
                //gameObject.transform.localScale = new Vector3(x / 1.5f, y / 1.5f, 1f);
                //partner.gameObject.transform.localScale = new Vector3(x2 * 1.5f, y2 * 1.5f, 1f);
            }
            else if (GM.sizeRatio == 2)
            {
                GM.sizeRatio = 3;
                Debug.Log("sizeRatio:" + GM.sizeRatio);
                gameObject.transform.localScale = new Vector3(x * 2.25f, y * 2.25f, 1f);
                partner.gameObject.transform.localScale = new Vector3(x2 / 2.25f, y2 / 2.25f, 1f);
                //gameObject.transform.localScale = new Vector3(x / 1.5f, y / 1.5f, 1f);
                //partner.gameObject.transform.localScale = new Vector3(x2 * 1.5f, y2 * 1.5f, 1f);
            }
        }

        /**
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
    **/


    }
}
