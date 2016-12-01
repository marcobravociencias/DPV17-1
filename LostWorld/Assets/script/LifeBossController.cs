using UnityEngine;
using System.Collections.Generic;

public class LifeBossController : MonoBehaviour {

	public float lifePoints;
	public List<CanonController> canonList;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		SuperBasicAI cara = GetComponent<SuperBasicAI>();
		bool face = cara.isFacingLeft;
		
		Debug.Log (face);
		if(lifePoints <= 0) {
			foreach(CanonController canon in canonList){
				canon.activate = false;
				
			}
			Destroy(this.gameObject);	
			// Aqui definimos que hacer cuando muera.
		}

		// Definimos en que momento se entra a las fases del boss
		// con mas if else.
		if(lifePoints <= 90) {
			foreach(CanonController canon in canonList)
				canon.activate = true;
			// Aqui definimos que hacer cuando muera.
		}

		if(lifePoints <= 50) {
			foreach(CanonController canon in canonList)
				canon.shootRate = 0.5f;
			// Aqui definimos que hacer cuando muera.
		}
		if(lifePoints <= 20) {
			foreach(CanonController canon in canonList)
				canon.shootRate = 0f;
				//StopCoroutine(locura);
				//StartCoroutine(locura);
			// Aqui definimos que hacer cuando muera.
		}
		/*if(lifePoints <= 0) {
			foreach(CanonController canon in canonList)
				canon.activate = false;
			// Aqui definimos que hacer cuando muera.
		}
		if(lifePoints <= 0) {
			foreach(CanonController canon in canonList)
				canon.activate = false;
			// Aqui definimos que hacer cuando muera.
		}*/

	}


	public void OnTriggerEnter2D(Collider2D other) {
		if(other.tag == "PlayerBullet")
			lifePoints -= 1;
	}
}
