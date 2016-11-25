using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogos : MonoBehaviour {
	public string msj;
	public float tiempo;
	public GUISkin skin;
	public IEnumerator rutina;

	// Use this for initialization
	void Start () {
		msj= " ";
		tiempo = 3.0f;
		//StartCoroutine(Mensaje());		
	}
	
	// Update is called once per frame
	void Update () {
		//StartCoroutine(Mensaje());		
	}

	IEnumerator Mensaje(){
		if(true){
			//GUI.Box(new Rect(10,10,Screen.width/2,150), "Dialogos");
			//yield return new WaitForSeconds(tiempo);
			msj = "Anciano : Hola !";
			yield return new WaitForSeconds(tiempo);
			msj = "Jugador : No !";
			yield return new WaitForSeconds(tiempo);
			msj = "Anciano : Si !";
			yield return new WaitForSeconds(tiempo);
			msj = "Jugador : Dale Perro !";
			yield return new WaitForSeconds(tiempo);
			msj = "Jugador : Soy de Ecatepec banda !";
			yield return new WaitForSeconds(tiempo);
			msj = "Anciano : No me dañes, toma $5000 !";
			yield return new WaitForSeconds(tiempo);
			msj = "Obtienes $5000 !";
			yield return new WaitForSeconds(tiempo);
			msj = " ";
		//Destroy (this.gameObject);
		}


		


		/*yield WaitForSeconds(tiempo);
		msj = "Hola !";
		yield WaitForSeconds(tiempo);
		msj = "No !";
		yield WaitForSeconds(tiempo);
		msj = "Si !";
		yield WaitForSeconds(tiempo);
		msj = "Dale Perro !";
		yield WaitForSeconds(tiempo);
		msj = "Camaron banda !";*/
	}

	void OnTriggerEnter2D(Collider2D collider){
		if (collider != null){
			rutina = Mensaje();
			StartCoroutine(rutina);		
		}
		Animator anim = GetComponent<Animator>();
		anim.enabled=false;
	}

	void OnTriggerExit2D(Collider2D collider){
		//if (collider != null){
		StopCoroutine(rutina);
		msj = " ";
			//Destroy (this.gameObject);		
		//}
		Animator anim = GetComponent<Animator>();
		anim.enabled=true;
	}

	void OnGUI(){
		GUI.skin = skin;
		//GUI.skin.fontSize = 25;
		int size = 25;
		float posX = Screen.width/20;
		float posY = Screen.height/10;
		if(msj != " "){
			GUI.Box(new Rect(10,10,Screen.width -20,150),"");
		}
		GUI.Label (new Rect (posX, posY, 600, 150), msj);

	}
}
