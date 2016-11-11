using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovMapa : MonoBehaviour {
	public Vector2 speed = new Vector2(1, 1);
 	public Vector2 direction = new Vector2(0,0);
  	public bool isLinkedToCamera = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update()
  {
    // Movement
    //Vector3 movement = new Vector3(speed.x * direction.x, speed.y * direction.y, 0);

  	float movX = Input.GetAxis ("Horizontal");
	float movY = Input.GetAxis ("Vertical");

	Vector3 movement = new Vector3(speed.x * movX, speed.y * movY, 0);

    movement *= Time.deltaTime;
    transform.Translate(movement);

    // Move the camera
    if (isLinkedToCamera)
    {
      Camera.main.transform.Translate(movement);
    }
  }
}
