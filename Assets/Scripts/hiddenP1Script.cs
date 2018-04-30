using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hiddenP1Script : MonoBehaviour {
    public int P1count=0;
    public AudioClip pickupSound;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "collectable")
        {
            other.gameObject.SetActive(false);
            AudioSource.PlayClipAtPoint(pickupSound, transform.position);
            P1count += 1;
            Debug.Log("P1 Count: "+P1count);
        }
    }

    public int getCount()
    {
        return P1count;
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
