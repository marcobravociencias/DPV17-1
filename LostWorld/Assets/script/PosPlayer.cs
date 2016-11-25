using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosPlayer : MonoBehaviour {
	public static float corX = 0f;
	public static float corY = 0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Awake(){
		DontDestroyOnLoad(this.gameObject);
	}
}
