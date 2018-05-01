using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water_death_trigger : MonoBehaviour {
    public GameObject P2;
    public GameObject P1;
    public GameObject RP1;
    public AudioClip respawnSound;
    public AudioClip dieSound;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "top_colliderP2")
        {
            P2.SetActive(false);
            AudioSource.PlayClipAtPoint(dieSound, transform.position);
            Debug.Log("wow1");
            StartCoroutine(MyMethodP2());
            Debug.Log("wow2");
        }
        else if (other.tag == "top_colliderP1")
        {
            P1.SetActive(false);
            AudioSource.PlayClipAtPoint(dieSound, transform.position);
            StartCoroutine(MyMethodP1());
        }

    }
    IEnumerator MyMethodP1()
    {
        Debug.Log("Before Waiting 2 seconds");
        yield return new WaitForSeconds(2);
        Debug.Log("After Waiting 2 Seconds");
        P1.transform.position = RP1.transform.position;
        P1.SetActive(true);
        AudioSource.PlayClipAtPoint(respawnSound, transform.position);
    }
    IEnumerator MyMethodP2()
    {
        Debug.Log("Before Waiting 2 seconds");
        yield return new WaitForSeconds(2);
        Debug.Log("After Waiting 2 Seconds");
        P2.transform.position = RP1.transform.position;
        P2.SetActive(true);
        AudioSource.PlayClipAtPoint(respawnSound, transform.position);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
