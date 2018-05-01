using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fangshuiTrigger : MonoBehaviour {
    public GameObject chouzou;
    public GameObject waterToBeDisabled;
    public GameObject waterToBeActive;
    public bool isTriggered;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag=="hiddenP1"|| other.tag == "hiddenP2")
        {
            Debug.Log("is triggered");
            isTriggered = true;
            //this.gameObject.SetActive(false);
            //chouzou.transform.position.y
            
            Debug.Log("is ending");

        }
    }
    // Use this for initialization
    void Start () {
        isTriggered = false;

    }
	
	// Update is called once per frame
	void Update () {
		if (isTriggered)
        {
            if(chouzou.transform.position.x < 39.5f|| transform.position.y > -8)
            {
                chouzou.transform.Translate(new Vector3(0.015f, 0, 0));
                transform.Translate(new Vector3(0, -0.04f, 0));
            }
            else
            {
                chouzou.SetActive(false);
                waterToBeDisabled.SetActive(false);
                waterToBeActive.SetActive(true);
                this.gameObject.SetActive(false);
            }
            
        }
	}

}
