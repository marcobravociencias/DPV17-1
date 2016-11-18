using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public Transform player;
	public float xMin;
	public float xMax;
	public float yMin;
	public float yMax;

	private void FixedUpdate () {
		//float moveX = Input.GetAxis ("Horizontal");
		//float moveY = Input.GetAxis ("Vertivcal");
		//transform.position = new Vector3 (Mathf.Clamp (player.position.x, xMin, xMax), Mathf.Clamp (player.position.y, yMin, yMax), -10.0f);
		
		Vector3 movement = new Vector3 (Mathf.Clamp (player.position.x, xMin, xMax), Mathf.Clamp (player.position.y, yMin, yMax), -11.0f);
		//movement *= Time.deltaTime;
		transform.position = movement;
	}
}
