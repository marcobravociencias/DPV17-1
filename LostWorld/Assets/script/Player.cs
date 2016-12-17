using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	[SerializeField] private GameObject disparoPrefab;
	[SerializeField] private GameObject disparoSalida;
	//public static float corX = 0f;
	//public static float corY = 0f;
	private GameObject disparoEfecto;
	

	//private GameObject disparo;
	public int vida;
	//public Movement mov = GetComponent<Movement>();
	// Use this for initialization
	void Start () {
		vida = 10;
		//Vector3 pos = new Vector3 (PosPlayer.corX, PosPlayer.corY, transform.position.z);
		//transform.position.x = PosPlayer.corX;
		//transform.position.y = PosPlayer.corY;
		//transform.position = transform.TransformPoint (new Vector3(PosPlayer.corX, PosPlayer.corY, transform.position.z));
			//Debug.Log (PosPlayer.corX+" , " + PosPlayer.corY);


	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("z")) {
			dispara ();
		}
	}

	public void dispara(){
		//if (disparo == null) {
			AudioSource audio = GetComponent<AudioSource>();
        	//audio.Play();
        	//audio.Play(44100);
        	audio.PlayDelayed(0f);
			GameObject disparo = Instantiate (disparoPrefab) as GameObject;
			/*if (disparoEfecto == null) {
				GameObject disparoEfecto = Instantiate (disparoSalida) as GameObject;//Animacion de disparo.
				disparoEfecto.transform.localScale += new Vector3(1.5f, 1.5f, 0);
				disparoEfecto.transform.Translate (15 * Time.deltaTime, 0, 0);
				disparo.transform.Translate (15 * Time.deltaTime, 0, 0);
			}*/
			Movement mov = GetComponent<Movement>(); 
			DisparoPreFab dir = disparo.GetComponent<DisparoPreFab>();
			int i = 1;
			if (mov.isFacingLeft){
				dir.izq = true;
				i = -1;
				//Debug.Log ("¡¡¡ Haz Muerto Perro !!!");
			}
			if (mov.anim.GetBool("Run")){
				//disparoEfecto.transform.position =this.transform.TransformPoint (new Vector3 (1.5f * i, 0.9f, 0)); 
				disparo.transform.position = this.transform.TransformPoint (new Vector3 (1.5f * i, 0.9f, 0));
			}else{
				//disparoEfecto.transform.position =this.transform.TransformPoint (new Vector3 (1.5f * i, 0.9f, 0)); 

				disparo.transform.position = this.transform.TransformPoint (new Vector3 (1.5f * i, 0.3f, 0));
			}
			



			//Cambiar depende de la pocicion
			//disparo.transform.rotation = this.transform.rotation;

		//}
	}

	public void danio(int golpe){
		vida -= golpe;
		Debug.Log ("Vida " + vida);
	}
	
	private void muerte(){
		if (vida == 0) {
			//Application.LoadLevel (2);
			Debug.Log ("¡¡¡ Haz Muerto Perro !!!");
			Application.LoadLevel("Batalla");
		}
	}

	public void OnTriggerEnter2D(Collider2D other) {
		if(other.tag == "BossAtack")
		this.danio(1);
		muerte ();
	}
	
}
