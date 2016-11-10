using UnityEngine;
using System.Collections;

public class HarpoonMovement : MonoBehaviour {

	public float speed = 10.0f;

	private Rigidbody2D rigidBody2D;
	private SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Start () {
		spriteRenderer = GetComponent<SpriteRenderer>();
		rigidBody2D = GetComponent<Rigidbody2D>();
		if (spriteRenderer.flipX)
			rigidBody2D.velocity = new Vector2(1.0f * speed, 0.0f);
		else 
			rigidBody2D.velocity = new Vector2(-1.0f * speed, 0.0f);
	}
	
	// Update is called once per frame
	void Update () {
		if (rigidBody2D.position.x < -15 || rigidBody2D.position.x > 15)
			Destroy(this.gameObject);
	}
}
