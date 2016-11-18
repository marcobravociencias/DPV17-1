using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovMapa : MonoBehaviour {
	public float velocidad = 0.3f;
  public bool seMueveCamara = false;
  public float rango = 0.05f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update() {
	    // Movement
	    //Vector3 movement = new Vector3(speed.x * direction.x, speed.y * direction.y, 0);

	  	float movX = Input.GetAxis ("Horizontal");
		float movY = Input.GetAxis ("Vertical");

			Vector3 movement = new Vector3(velocidad* movX, velocidad * movY, 0);

	    movement *= Time.deltaTime;
	    transform.Translate(movement);
	    //float camX = Camera.main.transform.position.x;
	    //float camY = Camera.main.transform.position.y;
	    /* if (dentro(0.001f)){
	    	seMueveCamara = false;
	    }else{
	    	seMueveCamara = true;
	    }*/
	    // Move the camera
	    //dentro(rango);
	    //float tamaño = 0.05f;
	    
		//Debug.Log (seMueveCamara);


	    /*if (seMueveCamara)
	    {
	      Camera.main.transform.Translate(movement);
	    }*/
  	}

  	void dentro(float tamaño){
  		float camX = Camera.main.transform.position.x;
	    //Debug.Log (camX);
	    float camY = Camera.main.transform.position.y;
	    //Debug.Log (camY);
	    float posX = transform.position.x;
	    //Debug.Log (posX);
		float posY = transform.position.y;
		//Debug.Log (posY);
		float LI = camY - tamaño;
		//Debug.Log (LI);
		float LS = camY + tamaño;
		//Debug.Log (LS);
		float LIz = camX - tamaño;
		//Debug.Log (LIz);
		float LD = camX + tamaño;
		//Debug.Log (LD);
			
		if (posX < LD && posX > LIz){
			if (posY > LI && posY < LS){
				seMueveCamara =  true;
			}
		}else{
			//seMueveCamara =  false;			
		}

  	}
}
