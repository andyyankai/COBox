using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTriggerScript : MonoBehaviour
{
    public GameObject P2;
    public GameObject P1;
    public GameObject RP2;
	public int death_count = 0;
    public AudioClip respawnSound;
    public AudioClip dieSound;

    void OnTriggerEnter2D(Collider2D other)
        {
        if (other.tag == "hiddenP2")
        {
            P2.SetActive(false);
            AudioSource.PlayClipAtPoint(dieSound, transform.position);

            Debug.Log ("diamond_count: " + GM.totalCount);
			GM.totalCount -= 1;
			Debug.Log ("diamond_count2: " + GM.totalCount);
			Debug.Log(GM.totalCount);
            StartCoroutine(MyMethodP2());
            Debug.Log("miao2");
        }
        else if (other.tag == "hiddenP1")
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
        P1.transform.position = RP2.transform.position;
        P1.SetActive(true);
        AudioSource.PlayClipAtPoint(respawnSound, transform.position);
    }
    IEnumerator MyMethodP2()
    {
        Debug.Log("Before Waiting 2 seconds");
        yield return new WaitForSeconds(2);
        Debug.Log("After Waiting 2 Seconds");
        P2.transform.position = RP2.transform.position;
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
