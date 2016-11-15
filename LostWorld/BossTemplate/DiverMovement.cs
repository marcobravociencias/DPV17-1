using UnityEngine;
using System.Collections;

public class DiverMovement : MonoBehaviour {

	public float speed;
	public float xMin;
	public float xMax;
	public float yMin;
	public float yMax;
	public bool isFacingLeft;
	public bool isFacingRight;

	//private Animator animator;
	private Rigidbody2D rigidBody2D;
	private SpriteRenderer spriteRenderer;
	private Component[] weapon;
	private DiverLifeController life;

	// Use this for initialization
	void Start () {
		speed = 8.0f;
		xMin = -15.0f;
		xMax = 15.0f;
		yMin = -5.5f;
		yMax = 5.5f;
		isFacingLeft = false;
		isFacingRight = true;
		
		rigidBody2D = GetComponent<Rigidbody2D>();
		spriteRenderer = GetComponent<SpriteRenderer>();
		weapon = GetComponentsInChildren<WeaponController>();
		life = GetComponent<DiverLifeController>();
	}

	void FixedUpdate () {
		if (life.life <= 0) {
			rigidBody2D.velocity = Vector2.zero;
			return;
		}
		
		float moveX = Input.GetAxis("Horizontal");
		float moveY = Input.GetAxis("Vertical");

		Vector2 movement = new Vector2(moveX, moveY);
		rigidBody2D.velocity = movement * speed;
		rigidBody2D.position = new Vector2 (
			Mathf.Clamp(rigidBody2D.position.x, xMin, xMax), 
            Mathf.Clamp(rigidBody2D.position.y, yMin, yMax)
		);

		if (moveX < 0 && isFacingLeft)
			FlipRight();
		else if (moveX > 0 && isFacingRight)
			FlipLeft();
	}

	private void FlipLeft () {
		isFacingLeft = true;
		isFacingRight = false;
		spriteRenderer.flipX = true;
		
		foreach (WeaponController w in weapon) {
			w.isFacingLeft = true;
			w.isFacingRight = false;
		}
	}

	private void FlipRight () {
		isFacingLeft = false;
		isFacingRight = true;
		spriteRenderer.flipX = false;

		foreach (WeaponController w in weapon) {
			w.isFacingLeft = false;
			w.isFacingRight = true;
		}
	}
}
