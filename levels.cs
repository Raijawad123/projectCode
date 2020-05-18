using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levels : MonoBehaviour {

	public void LevelSelection(int num)
	{

		PlayerPrefs.SetInt ("LevelNo", num);
		SceneManager.LoadScene("LoadScene"); 
		
	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
