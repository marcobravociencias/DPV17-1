using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour {
	public Transform player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D col){
		if(col.gameObject.tag == "Player"){
			if( gameObject.tag == "Salida"){
				//Application.LoadLevel(Application.loadedLevelName);
				if (Application.loadedLevelName == "Casas"){
					Application.LoadLevel("Bosque");
				}
				if (Application.loadedLevelName == "CasasR0Bosque"){
					Application.LoadLevel("Bosque");
				}	
			}

			if( gameObject.tag == "Entrada"){
				//Application.LoadLevel(Application.loadedLevelName);
				if (Application.loadedLevelName == "Bosque"){
					Application.LoadLevel("CasasR0Bosque");


					//Vector3 movement = new Vector3 (-1f, 0, player.position.z);
					//player.transform.Translate(movement);
				}
			}
			if( gameObject.tag == "EntradaCasa"){
				if (gameObject.name == "EntradaCasa1"){
					Application.LoadLevel("Casa1");	
				}
				if (gameObject.name == "EntradaCasa2"){
					Application.LoadLevel("Casa2");	
				}
				if (gameObject.name == "EntradaCasaLab"){
					Application.LoadLevel("Casa2");	
				}
				//Application.LoadLevel(Application.loadedLevelName);
				
			}
		}
	}
}