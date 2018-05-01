using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class checkpoint : MonoBehaviour {

	public GM gm;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "hiddenP1"|| other.gameObject.tag == "hiddenP2")
        {
			gm.save_score();
            SceneManager.LoadScene(1);
        }
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
