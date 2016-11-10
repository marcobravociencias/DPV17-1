using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DiverLifeController : MonoBehaviour {

	public float life;
	public Image heart1; 
	public Image heart2; 
	public Image heart3; 
	public Image heart4;
	
	private Animator animator;

	// Use this for initialization
	void Start () {
		life = 100f;
		animator = transform.GetComponent<Animator>();
	}

	// TODO Require objects above.
	void Update () {
		if (life == 75)
			heart4.enabled = false;
		else if (life == 50)
			heart3.enabled = false;
		else if (life == 25)
			heart2.enabled = false;
		else if (life == 0) {
			heart1.enabled = false;
			animator.SetTrigger("die");
		}
	}

	void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "Enemy" && life >= 0) {
			life -= 25f;
			Debug.Log("Hit by enemy");
		}
	}
}
