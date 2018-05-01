using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endSc : MonoBehaviour {

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "hiddenP2"|| other.tag == "hiddenP1")
        {
            MyMethodP1();
            SceneManager.LoadScene(0);
        }
    }

    IEnumerator MyMethodP1()
    {
        Debug.Log("Before Waiting 2 seconds");
        yield return new WaitForSeconds(5);
        Debug.Log("After Waiting 2 Seconds");
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
