using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public DiverLifeController diverLife;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (diverLife.life <= 0) {
			Debug.Log("Die Message");
		}
	}
}
