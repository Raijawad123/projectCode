using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour {

	public GameObject levelSelection;
	public GameObject gunSelection;
	public GameObject loading;
	public GameObject settings;
	public AudioClip audioClip;
	AudioSource source;
	void Start () {
		source = GetComponent<AudioSource> ();
	}
	public void goTOLevelSelection(){
		source.PlayOneShot (audioClip); // sound chalane K liye ye wali line paste karien
		levelSelection.SetActive (true);
	}

	public void backToMainMenu(){
		levelSelection.SetActive (false);
	}

	public void selectLevel(int no){
		source.PlayOneShot (audioClip); 
		PlayerPrefs.SetInt ("LevelNo", no);
		loading.SetActive (true);
		StartCoroutine ("LoadLevels");
	}


	IEnumerator LoadLevels(){
		yield return new WaitForSeconds (5f); // y wala loading ka time hai
		SceneManager.LoadScene (1);
	
	}
	public void goToSettings(){
		settings.SetActive (true);
	}
	public void goTOMainSettings(){
		settings.SetActive(false);
	}

	public void playsound()
	{

		if(AudioListener.pause)
			AudioListener.pause = false;
		else
			AudioListener.pause = true;
	}




}
