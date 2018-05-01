using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score_update : MonoBehaviour {

	public Text your_score;
	public Text best_score;

	private int y_score;
	private int b_score;
	// Use this for initialization
	void Start () {
		your_score.text = "" + GlobalControl.Instance.your_score*100;
		best_score.text = "" + GlobalControl.Instance.best_score*100;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
