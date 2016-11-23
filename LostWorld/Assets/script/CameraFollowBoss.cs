using UnityEngine;
using System.Collections;

public class CameraFollowBoss : MonoBehaviour {

	public Transform player;
	public float xMin;
	public float xMax;
	public float yMin;
	public float yMax;

	private void FixedUpdate() {
		transform.position = new Vector3(
			Mathf.Clamp (player.position.x, xMin, xMax), 
			Mathf.Clamp (player.position.y, yMin, yMax), 
			-10.0f
		);
	}
}
