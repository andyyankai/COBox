using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalControl : MonoBehaviour {

	public static GlobalControl Instance;

	//data to save;
	public int your_score = 0;
	public int best_score = 0;

	//initial
	private void Awake()
	{
		if(Instance==null)
		{
			DontDestroyOnLoad(gameObject);
			Instance = this;
		}
		else if(Instance!=null)
		{
			Destroy(gameObject);
		}
	}
}
