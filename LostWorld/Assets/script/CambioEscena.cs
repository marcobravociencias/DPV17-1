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
			if( gameObject.tag == "Enemigo"){
				Application.LoadLevel("Batalla");
			}
			if( gameObject.tag == "Salida"){
				//Application.LoadLevel(Application.loadedLevelName);
				if (Application.loadedLevelName == "Casas"){
					//PosPlayer.corX = col.gameObject.transform.position.x;
					//PosPlayer.corY = col.gameObject.transform.position.y;
					Application.LoadLevel("Bosque");
				}
				if (Application.loadedLevelName == "CasasR0Bosque"){
					Application.LoadLevel("Bosque");
				}	
			}

			if( gameObject.tag == "Entrada"){
				//Application.LoadLevel(Application.loadedLevelName);
				if (Application.loadedLevelName == "Bosque"){
					//PosPlayer.corX = 0.17f;
					//PosPlayer.corY = 1.96f;

					Application.LoadLevel("Casas");


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
				if(gameObject.name == "SubeCasa1"){
					Application.LoadLevel("Casa1_a");
				}
				if(gameObject.name == "SubeCasa2"){
					Application.LoadLevel("Casa2_a");
				}
				if(gameObject.name == "BajaCasa1"){
					Application.LoadLevel("Casa1");
				}
				if(gameObject.name == "BajaCasa2"){
					Application.LoadLevel("Casa2");
				}
				//Application.LoadLevel(Application.loadedLevelName);
			}
			if (gameObject.tag == "SalidaCasa"){
					Application.LoadLevel("Casas");
			}

		}
	}
}