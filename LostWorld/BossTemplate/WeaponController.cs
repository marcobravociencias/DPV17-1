using UnityEngine;
using System.Collections;

public class WeaponController : MonoBehaviour {

	public Transform harpoon;
	public float shootRate;
	public bool isFacingLeft;
	public bool isFacingRight;
	
	private float nextShoot;
	private Animator animator;
	private DiverMovement diver;
	private SpriteRenderer harpoonSR;

	// Use this for initialization
	void Start () {
		shootRate = 2.5f;
		isFacingLeft = true;
		isFacingRight = false;

		animator = transform.parent.GetComponent<Animator>();
		harpoonSR = harpoon.GetComponent<SpriteRenderer>();
		diver = transform.parent.GetComponent<DiverMovement>();
	}
	
	// Update is called once per frame
	void Update () {
		StartCoroutine(InTimeAnimations() );
	}

	private IEnumerator InTimeAnimations () {
		 if (Input.GetButtonDown("Fire1") && Time.time > nextShoot) {
			nextShoot = Time.time + shootRate;
			animator.SetTrigger("useHarpoon");
			yield return new WaitForSeconds (0.5f);
			if (isFacingLeft)
				harpoonSR.flipX = true;
			else
				harpoonSR.flipX = false;
			Instantiate(harpoon, transform.position, transform.rotation);
		}
 	}
}
