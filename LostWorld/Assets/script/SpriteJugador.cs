using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteJugador : MonoBehaviour {
	public Sprite sprite0; // Drag your first sprite here
	public Sprite sprite1; // Drag your second sprite here
	public Sprite sprite2; // Drag your first sprite here
	public Sprite sprite3; // Drag your second sprite here
	public Sprite sprite4; // Drag your first sprite here
	public Sprite sprite5; // Drag your second sprite here
	public Sprite sprite6; // Drag your first sprite here
	public Sprite sprite7; // Drag your second sprite here
	public Sprite sprite8; // Drag your first sprite here
	public float velocidadCambio = 0.2f;
	private SpriteRenderer spriteRenderer;
	// Use this for initialization
	void Start () {
		spriteRenderer = GetComponent<SpriteRenderer>(); // we are accessing the SpriteRenderer that is attached to the Gameobject
    	if (spriteRenderer.sprite == null){
    		spriteRenderer.sprite = sprite0;
    	}
    	StartCoroutine (Movimiento ());		
	}
     
    IEnumerator Movimiento () {
         while (true) {
			if (Input.GetAxis ("Vertical") != 0){
				if (Input.GetAxis ("Vertical") < 0) {
					CambiaAbajo();	
					yield return new WaitForSeconds(velocidadCambio);
				}else if (Input.GetAxis ("Vertical") > 0) {
					CambiaArriba();	
					yield return new WaitForSeconds(velocidadCambio);
				}
			}else{
				if (Input.GetAxis ("Horizontal") < 0) {
					CambiaIzquierda();	
					yield return new WaitForSeconds(velocidadCambio);
				}else if (Input.GetAxis ("Horizontal") > 0) {
					CambiaDerecha();	
					yield return new WaitForSeconds(velocidadCambio);
				}	
			}
			yield return new WaitForSeconds(velocidadCambio*0);
        }
        //yield return new WaitForSeconds(velocidadCambio);
    }

	void CambiaAbajo (){
		spriteRenderer.flipX = false;
		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			spriteRenderer.sprite = sprite0;	
		}

		if (Input.GetAxis ("Vertical") < 0) {
			//spriteRenderer.sprite = sprite0;
			if (spriteRenderer.sprite == sprite0) {
				spriteRenderer.sprite = sprite1;
			} else if (spriteRenderer.sprite == sprite1) {
				spriteRenderer.sprite = sprite2;
			} else if (spriteRenderer.sprite == sprite2) {
				spriteRenderer.sprite = sprite1;
			}	
		}
		if (Input.GetAxis ("Vertical") == 0) {
			spriteRenderer.sprite = sprite0;
		}
	}

	void CambiaArriba (){
		spriteRenderer.flipX = false;
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			spriteRenderer.sprite = sprite3;	
		}

		if (Input.GetAxis ("Vertical") > 0) {
			//spriteRenderer.sprite = sprite0;
			if (spriteRenderer.sprite == sprite3) {
				spriteRenderer.sprite = sprite4;
			} else if (spriteRenderer.sprite == sprite4) {
				spriteRenderer.sprite = sprite5;
			} else if (spriteRenderer.sprite == sprite5) {
				spriteRenderer.sprite = sprite4;
			}	
		}
		if (Input.GetAxis ("Vertical") == 0 ) {
			spriteRenderer.sprite = sprite3;
		}
	}

	void CambiaDerecha (){
		spriteRenderer.flipX = true;
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			spriteRenderer.sprite = sprite6;	
		}

		if (Input.GetAxis ("Horizontal") > 0) {
			//spriteRenderer.sprite = sprite0;
			if (spriteRenderer.sprite == sprite6) {
				spriteRenderer.sprite = sprite7;
			} else if (spriteRenderer.sprite == sprite7) {
				spriteRenderer.sprite = sprite8;
			} else if (spriteRenderer.sprite == sprite8) {
				spriteRenderer.sprite = sprite7;
			}	
		}
		if (Input.GetAxis ("Horizontal") == 0 ) {
			spriteRenderer.sprite = sprite6;
		}
		//spriteRenderer.flipX = false;
	}

	void CambiaIzquierda (){
		spriteRenderer.flipX = false;
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			spriteRenderer.sprite = sprite6;	
		}

		if (Input.GetAxis ("Horizontal") < 0) {
			//spriteRenderer.sprite = sprite0;
			if (spriteRenderer.sprite == sprite6) {
				spriteRenderer.sprite = sprite7;
			} else if (spriteRenderer.sprite == sprite7) {
				spriteRenderer.sprite = sprite8;
			} else if (spriteRenderer.sprite == sprite8) {
				spriteRenderer.sprite = sprite7;
			}	
		}
		if (Input.GetAxis ("Horizontal") == 0 ) {
			spriteRenderer.sprite = sprite6;
		}
	}
}