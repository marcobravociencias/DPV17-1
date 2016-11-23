using UnityEngine;
using System.Collections;

public class SuperBasicAI : MonoBehaviour {

	public float speed;
	public bool hitLimit;
	public bool isFacingLeft;
	
	private float moveX;
	private float moveY;
	private Rigidbody2D rigidBody2D;
	private SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Start() {
		rigidBody2D = GetComponent<Rigidbody2D>();
		spriteRenderer = GetComponent<SpriteRenderer>();
		moveX = 0.1f;
		moveY = 0.0f;
	}
	
	// Update is called once per frame
	void Update() {
		if(hitLimit)
			moveX *= -1.0f;

		MoveXAxis();
	}

	public void MoveXAxis() {
		if(moveX > 0 && isFacingLeft)
			FlipRight();
		else if(moveX < 0 && !isFacingLeft)
			FlipLeft();

		Vector2 movement = new Vector2(moveX, moveY);
		rigidBody2D.velocity = movement * speed;
		rigidBody2D.position = new Vector2(rigidBody2D.position.x, rigidBody2D.position.y);
	}

	public void OnTriggerEnter2D(Collider2D other) {
		if(other.tag == "BossLimit")
			hitLimit = true;
	}

	public void OnTriggerExit2D(Collider2D other) {
		if(other.tag == "BossLimit")
			hitLimit = false;
	}

	private void FlipLeft() {
		isFacingLeft = true;
		spriteRenderer.flipX = true;
	}

	private void FlipRight() {
		isFacingLeft = false;
		spriteRenderer.flipX = false;
	}
}
