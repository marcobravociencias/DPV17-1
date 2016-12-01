using UnityEngine;
using System.Collections;

public class CanonController : MonoBehaviour {

	public GameObject bullet;
	public float shootRate;
	public bool activate;
	private float timer;

	// Use this for initialization
	void Start () {
		//StartCoroutine (Destruye ());
		timer = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if(timer >= shootRate && activate) {
			timer = 0.0f;
			Instantiate(bullet, transform.position, Quaternion.identity);

		}
	}

	/*private IEnumerator Destruye(){
		yield return new WaitForSeconds (3.0f);
		Destroy (this.gameObject);
	}*/
}
