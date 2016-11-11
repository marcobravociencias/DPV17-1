using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

	public float xMin;
	public float xMax;
	public float yMin;
	public float yMax;
	public float speed;

	private Vector2 movement;
	private float moveX;
	private float moveY;
	private Rigidbody2D rigidBody2D;
	private SpriteRenderer enemySR;
	private EnemyLifeController life;

	void Start () {
		speed = 15f;
		moveX = -1f;
		moveY = 1f;
		xMin = -25f;
		xMax = 25f;
		yMin = -3f;
		yMax = 4f;

		rigidBody2D = GetComponent<Rigidbody2D>();
		enemySR = GetComponent<SpriteRenderer>();
		life = GetComponent<EnemyLifeController>();
	}

	void Update () {
		if (life.life <= 0)
			Die();
		else if (life.life < 20 && life.life > 0)
			Hard();
		else if (life.life < 60 && life.life >= 20)
			Medium();
		else if (life.life <= 100 && life.life >= 60)
			Normal();
	}

	private void Hard () {
		if (transform.position.x < xMin) {
			moveX = 1f;
			enemySR.flipX = true;
		} else if (transform.position.x > xMax) {
			moveX = -1f;
			enemySR.flipX = false;
		} else if (transform.position.y < yMin)
			moveY = 1f;
		else if (transform.position.y > yMax)
			moveY = -1f;

		movement = new Vector2(moveX, moveY);
		rigidBody2D.velocity = movement * 20f;
	}

	private void Medium () {
		if (transform.position.x < xMin) {
			moveX = 1f;
			enemySR.flipX = true;
		} else if (transform.position.x > xMax) {
			moveX = -1f;
			enemySR.flipX = false;
		} else if (transform.position.y < yMin)
			moveY = 1f;
		else if (transform.position.y > yMax)
			moveY = -1f;

		movement = new Vector2(moveX, moveY);
		rigidBody2D.velocity = movement * 10f;
	}

	private void Normal () {
		if (transform.position.x < xMin) {
			moveX = 1f;
			moveY = -3f;
			enemySR.flipX = true;
		} else if (transform.position.x > xMax) {
			moveX = -1f;
			moveY = 4f;;
			enemySR.flipX = false;
		}

		movement = new Vector2(moveX * speed, moveY);
		rigidBody2D.position = new Vector2(rigidBody2D.position.x, moveY);
		rigidBody2D.velocity = movement;
	}

	private void Die () {
		enemySR.flipY = true;
		rigidBody2D.velocity = Vector2.zero;
		rigidBody2D.gravityScale = 4f;
	}
}
