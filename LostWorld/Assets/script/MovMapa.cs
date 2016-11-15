using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovMapa : MonoBehaviour {
	public float velocidad = 0.3f;
  	public bool seMueveCamara = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update() {
	    // Movement
	    //Vector3 movement = new Vector3(speed.x * direction.x, speed.y * direction.y, 0);

	  	float movX = Input.GetAxis ("Horizontal");
		float movY = Input.GetAxis ("Vertical");

			Vector3 movement = new Vector3(velocidad* movX, velocidad * movY, 0);

	    movement *= Time.deltaTime;
	    transform.Translate(movement);

	    // Move the camera
	    if (seMueveCamara)
	    {
	      Camera.main.transform.Translate(movement);
	    }
  	}
}
