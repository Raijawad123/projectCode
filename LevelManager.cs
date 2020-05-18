using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LevelManager : MonoBehaviour {


public static LevelManager instance;

	 int waterammount;
	 int appleammount;
	 int keyammount;

	public int waterreq;
	public int applereq;
	public int keyreq;

	public GameObject LevelEnd;
	// Use this for initialization
	void Start () {
		waterammount = 0;
		appleammount = 0;
		keyammount = 0;
		if (instance == null)
			instance = this;
	}

	public void waterPicked(){
		waterammount++;
		Debug.Log ("ok");
		if (waterammount == waterreq && appleammount==applereq && keyammount==keyreq) {
			Debug.Log ("Here");
			LevelEnd.SetActive (true);
		}
	
	}
	private LevelManager(){
	}

	public void applePicked(){
		appleammount++;
		Debug.Log ("ok");
		if (waterammount == waterreq && appleammount==applereq && keyammount==keyreq) {
			Debug.Log ("Here");
			LevelEnd.SetActive (true);
		}

	}
	public void keyPicked(){
		keyammount++;
		Debug.Log ("ok");
		if (waterammount == waterreq && appleammount==applereq  && keyammount==keyreq) {
			Debug.Log ("Here");
			LevelEnd.SetActive (true);
		}

	}

}
