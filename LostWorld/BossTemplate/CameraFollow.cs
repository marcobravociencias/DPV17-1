using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public Transform player;
	public float xMin = -5.0f;
	public float xMax = 5.0f;

	private void FixedUpdate () {
		float moveX = Input.GetAxis ("Horizontal");
		transform.position = new Vector3 (
			Mathf.Clamp (player.position.x, xMin, xMax), 
			0.0f, 
			-10.0f
		);
	}
}
