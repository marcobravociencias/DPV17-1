using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	[SerializeField] private GameObject disparoPrefab;
	//private GameObject disparo;
	private int vida;
	//public Movement mov = GetComponent<Movement>();
	// Use this for initialization
	void Start () {
		vida = 10;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("z")) {
			dispara ();
		}
	}

	public void dispara(){
		//if (disparo == null) {
			GameObject disparo = Instantiate (disparoPrefab) as GameObject;
			//disparo.transform.Translate (15 * Time.deltaTime, 0, 0);
			Movement mov = GetComponent<Movement>(); 
			DisparoPreFab dir = disparo.GetComponent<DisparoPreFab>();
			int i = 1;
			if (mov.isFacingLeft){
				dir.izq = true;
				i = -1;
				//Debug.Log ("¡¡¡ Haz Muerto Perro !!!");
			}
			if (mov.anim.GetBool("Run")){
				disparo.transform.position = this.transform.TransformPoint (new Vector3 (1.5f * i, 0.9f, 0));
			}else{
				disparo.transform.position = this.transform.TransformPoint (new Vector3 (1.5f * i, 0.3f, 0));
			}

			//Cambiar depende de la pocicion
			//disparo.transform.rotation = this.transform.rotation;

		//}
	}

	public void danio(int golpe){
		vida -= golpe;
		muerte ();
		Debug.Log ("Vida " + vida);
	}
	
	private void muerte(){
		if (vida == 0) {
			//Application.LoadLevel (2);
			Debug.Log ("¡¡¡ Haz Muerto Perro !!!");
		}
	}
	
}
