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
		if(gameObject.name == "Viejo1"){
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
		}

		if(gameObject.name == "Punk"){
			//GUI.Box(new Rect(10,10,Screen.width/2,150), "Dialogos");
			//yield return new WaitForSeconds(tiempo);
			msj = "Punk : Hola !";
			yield return new WaitForSeconds(tiempo);
			msj = "Punk : Soy un PUNK !";
			yield return new WaitForSeconds(tiempo);
			msj = "Jugador : Si, pero no rifas !";
			yield return new WaitForSeconds(tiempo);
			msj = "Jugador : Mejor subele al cumbion !";
			yield return new WaitForSeconds(tiempo);
			msj = "Punk : Ya estas rey, cumbion !";
			yield return new WaitForSeconds(tiempo);
			msj = " ";
		}


		if(gameObject.name == "Dama"){
			//GUI.Box(new Rect(10,10,Screen.width/2,150), "Dialogos");
			//yield return new WaitForSeconds(tiempo);
			msj = "Dama : Si tan solo hubieramos sido más \n concientes !";
			yield return new WaitForSeconds(tiempo);
			msj = "Dama : Antes todo era mejor !";
			yield return new WaitForSeconds(tiempo);
			msj = "Dama : Lastima por la niña de la otra casa !";
			yield return new WaitForSeconds(tiempo);
			msj = "Dama : Es tan pequeña y nadie puede \n ayudarla!";
			yield return new WaitForSeconds(tiempo);
			msj = " ";
		}

		if(gameObject.name == "Viejo2"){
			tiempo = 5;
			//GUI.Box(new Rect(10,10,Screen.width/2,150), "Dialogos");
			//yield return new WaitForSeconds(tiempo);
			msj = "ViejoPoderoso : Mi nieta, mi unica razon esta \n a punto de morir :( !";
			yield return new WaitForSeconds(tiempo);
			msj = "ViejoPoderoso : Antes todo era mejor !";
			yield return new WaitForSeconds(tiempo);
			msj = "ViejoPoderoso : Si tan solo alguien huiera hecho algo a tiempo\n el cambio climatico no me hubiera quitado todo!";
			yield return new WaitForSeconds(tiempo);
			msj = "ViejoPoderoso : Fui un hombre poderoso pero ciego, lo teniamos frente a nosotros\n pero no hicimos nada para combatirlo...!";
			yield return new WaitForSeconds(tiempo);
			msj = " ";
		}

		if(gameObject.name == "Viejo2_a"){
			tiempo = 5;
			//GUI.Box(new Rect(10,10,Screen.width/2,150), "Dialogos");
			//yield return new WaitForSeconds(tiempo);
			msj = "ViejoPoderoso : Mi nieta enfermo desde que el aire sobrepaso\n los limites de contaminacion !";
			yield return new WaitForSeconds(tiempo);
			msj = "ViejoPoderoso : Esta muy enferma, quisiera saber que causa toda esta\n contaminacion y poder destruirlo !";
			yield return new WaitForSeconds(tiempo);
			msj = "ViejoPoderoso : Pero a mi edad es muy dificil ir al bosque a explorar !";
			yield return new WaitForSeconds(tiempo);
			msj = "ViejoPoderoso : Ayuda a mi nieta porfavor !!!!";
			yield return new WaitForSeconds(tiempo);
			msj = " ";
		}

		if(gameObject.name == "NinaMoribunda"){
			tiempo = 5;
			//GUI.Box(new Rect(10,10,Screen.width/2,150), "Dialogos");
			//yield return new WaitForSeconds(tiempo);
			msj = "Niña Moribunda : Ojala tuviera fuerzas para salir a jugar *cof*cof !";
			yield return new WaitForSeconds(tiempo);
			msj = "Niña Moribunda : Mi abuelo dice que antes todo era verde y lleno de vida !";
			yield return new WaitForSeconds(tiempo);
			msj = "Niña Moribunda : *COF *COF *COF !";
			yield return new WaitForSeconds(tiempo);
			msj = "Niña Moribunda : VOY A MORIR !!! *cof *cof !!!!";
			yield return new WaitForSeconds(tiempo);
			msj = "Niña Moribunda : *Lagrimas y llanto, mucho llanto !!!!";
			yield return new WaitForSeconds(tiempo);
			msj = " ";
		}

		if(gameObject.name == "BossMalo"){
			tiempo = 7;
			//GUI.Box(new Rect(10,10,Screen.width/2,150), "Dialogos");
			//yield return new WaitForSeconds(tiempo);
			msj = "FIM-V : Mi Función es ayudar a los humanos quemando toda su basura, botellas, neumáticos, materia prima, etc…!";
			yield return new WaitForSeconds(tiempo);
			msj = "FIM-V : Después de quemarlos expulso el humo negro al aire, eh estado en funcionamiento desde el 2030... !";
			yield return new WaitForSeconds(tiempo);
			msj = "FIM-V :  no puedo parar mientras exista basura, y la luz solar alimente mi fuente de poder.!";
			yield return new WaitForSeconds(tiempo);
			msj = "FIM-V : Sabes, últimamente no eh visto a ningún humano por aquí...";
			yield return new WaitForSeconds(tiempo);
			msj = "FIM-V : pero no importa yo estoy programado para ayudarlos con su basura y eso hare !!!!";
			yield return new WaitForSeconds(tiempo);
			msj = " ";
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
		float posX = Screen.width/20;
		float posY = Screen.height/10;
		if(msj != " "){
			GUI.Box(new Rect(10,10,Screen.width -80,150),"");
		}
		GUI.Label (new Rect (posX, posY, 800, 150), msj);

	}
}
/*Mi nombre es  FIM-V 
Mi Función es ayudar a los humanos quemando toda su basura, botellas, neumáticos, materia prima, etc…
Después de quemarlos expulso el humo negro al aire, eh estado en funcionamiento desde el 2030 y no puedo parar mientras exista basura, y la luz solar alimente mi fuente de poder.
Sabes, últimamente no eh visto a ningún humano por aquí, pero no importa yo estoy programado para ayudarlos con su basura y eso aré...*/