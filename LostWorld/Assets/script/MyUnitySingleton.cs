using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyUnitySingleton : MonoBehaviour {

	private static MyUnitySingleton instance = null;
    public Application fondo;
 	public static MyUnitySingleton Instance {
    get { return instance; }
 }
 void Update(){
    if (Application.loadedLevelName == "Batalla"){
        AudioSource audio = GetComponent<AudioSource>();
        Debug.Log ("Musica Destruida");
        Destroy(this.gameObject);
    }
 }
 
 void Awake() {
    
     if (instance != null && instance != this) {
         Destroy(this.gameObject);
         return;
     } else {
         instance = this;
     }
     DontDestroyOnLoad(this.gameObject);
     /*if (Application.loadedLevelName == "Batalla"){
		AudioSource audio = GetComponent<AudioSource>();
		audio.Pause();
     }*/
 }

}
