using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveupdown : MonoBehaviour {


    public AnimationCurve myCurve;

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector2(transform.position.x, myCurve.Evaluate((Time.time % myCurve.length)));
    }
} 
