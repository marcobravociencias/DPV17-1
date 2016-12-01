using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour {

	public float xMax; // Use -13
	public float xMin; // Use -5
	public float y; // Use 20
	public int direccion;


	// Use this for initialization
	void Start () {
		if(true){
			direccion = -1;
		}else{
			direccion = 1;
		}
		GetComponent<Rigidbody2D>().AddForce(new Vector2(direccion * Random.Range(xMin, xMax), y) * 50);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnTriggerEnter2D(Collider2D other) {
		if(other.tag == "Player"){
			Destroy(gameObject);
	
		}else if(other.tag == "Ground")
			Destroy(gameObject);
	}

	
}
