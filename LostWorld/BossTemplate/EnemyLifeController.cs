using UnityEngine;
using System.Collections;

public class EnemyLifeController : MonoBehaviour {

	public int life;

	// Use this for initialization
	void Start () {
		life = 100;
	}

	void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "Harpoon") {
			life -= 10;
			Destroy(other.gameObject);
		}
	}
}
