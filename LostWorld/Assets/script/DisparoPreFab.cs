using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoPreFab : MonoBehaviour {
	//[RequireComponent(typeof(AudioSource))]
	public float velocidad = 10.0f;
	public int danio = 1;
	public bool izq = false;
	private SpriteRenderer spriteRenderer;
	// Use this for initialization
	void Start () {
		//AudioSource audio = GetComponent<AudioSource>();
        //audio.Play();
        //audio.Play(44100);
		StartCoroutine (Destruye ());
		spriteRenderer = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		if (!izq){
			transform.Translate (velocidad * Time.deltaTime, 0, 0);
			spriteRenderer.flipX = false;		
		}else {
			transform.Translate (-velocidad * Time.deltaTime, 0, 0);
			spriteRenderer.flipX = true;
		}
	}
	void OnTriggerEnter2D(Collider2D collider){
		if (collider != null){
			Destroy (this.gameObject);
		}
	}

	void OnCollisionEnter2D(Collision2D colision){
		//Enemigo enemigo = colision.GetComponent<Enemigo> ();
		//if (enemigo != null) {
		//	enemigo.danio (danio);
		//}
		SuperBasicAI boss = GetComponent<SuperBasicAI> ();
		if (boss != null) {
			boss.danio (danio);
		}
		if (colision != null){
			Destroy (this.gameObject);
		}
	}

	private IEnumerator Destruye(){
		yield return new WaitForSeconds (3.0f);
		Destroy (this.gameObject);
	}

	public void setIzq(bool val){
		izq = val;
	}
}
