using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float speed;
	public bool isFacingLeft;
	public bool isGrounded;
	public Animator anim;

	//private Animator animator;
	private Rigidbody2D rigidBody2D;
	private SpriteRenderer spriteRenderer;

	void Start() {
		rigidBody2D = GetComponent<Rigidbody2D>();
		spriteRenderer = GetComponent<SpriteRenderer>();
		anim = GetComponent<Animator>();
	}

	void FixedUpdate() {
		float moveX = Input.GetAxis("Horizontal");
		//float moveY = Input.GetAxis("Vertical");

		if(Input.GetKeyDown("space") && isGrounded){

			rigidBody2D.AddForce(transform.up * 800 );
		}
		if(Input.GetAxis("Horizontal") == 0 ){
			anim.SetBool("Run", false);
		}else{
		anim.SetBool("Run", true);
			
		}
		if(isGrounded){
			MoveXYAxis(moveX, 0.0f);
		}
	}

	private void FlipLeft() {
		isFacingLeft = true;
		spriteRenderer.flipX = false;
	}

	private void FlipRight() {
		isFacingLeft = false;
		spriteRenderer.flipX = true;
	}

	public void MoveXYAxis(float moveX, float moveY) {
		//anim.SetBool("Run", true);
		Vector2 movement = new Vector2(moveX, moveY);
		rigidBody2D.velocity = movement * speed;
		rigidBody2D.position = new Vector2(rigidBody2D.position.x, rigidBody2D.position.y);

		if(moveX > 0 && isFacingLeft)
			FlipRight();
		else if(moveX < 0 && !isFacingLeft)
			FlipLeft();
	}

	public void OnTriggerEnter2D(Collider2D other) {
		if(other.tag == "Ground"){
			isGrounded = true;
		}
		if(other.tag == "GroundEnemy"){
			isGrounded = true;
		}
	}

	public void OnTriggerExit2D(Collider2D other) {
		if(other.tag == "Ground"){
			isGrounded = false;
		}
		if(other.tag == "GroundEnemy"){
			isGrounded = true;
		}

	}
}
