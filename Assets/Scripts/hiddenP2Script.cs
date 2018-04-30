using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hiddenP2Script : MonoBehaviour {
    public int P2count = 0;
    public AudioClip pickupSound;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "collectable")
        {
            other.gameObject.SetActive(false);
            AudioSource.PlayClipAtPoint(pickupSound, transform.position);
            P2count += 1;
            Debug.Log("P2 Count: " + P2count);
        }
    }
    public int getCount()
    {
        return P2count;
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
