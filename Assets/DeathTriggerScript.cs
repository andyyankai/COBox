using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTriggerScript : MonoBehaviour
{
    public GameObject P2;
    public GameObject P1;
    public GameObject RP2;
    void OnTriggerEnter2D(Collider2D other)
        {
        if (other.tag == "hiddenP2")
        {
            P2.SetActive(false);
            Debug.Log("miao");
            StartCoroutine(MyMethodP2());
            Debug.Log("miao2");
        }
        else if (other.tag == "hiddenP1")
        {
            P1.SetActive(false);
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
    }
    IEnumerator MyMethodP2()
    {
        Debug.Log("Before Waiting 2 seconds");
        yield return new WaitForSeconds(2);
        Debug.Log("After Waiting 2 Seconds");
        P2.transform.position = RP2.transform.position;
        P2.SetActive(true);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }
}
