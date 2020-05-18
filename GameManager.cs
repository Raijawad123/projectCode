using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
	public GameObject Paused;
	public GameObject Levels;
	int LevelNo;
	int nextLevel;
	int tounlock;
	// Use this for initialization
	void Start () {
			LevelNo = PlayerPrefs.GetInt("LevelNo");
			game(LevelNo);
	}

	void game(int childNo)
	{
		Levels.transform.GetChild(childNo).gameObject.SetActive (true);
	}

	public void paused()
	{
		Time.timeScale = 0;
		Paused.SetActive (true);

	}
	public void replay()
	{
		Time.timeScale = 1;
		Paused.SetActive (false);
	}
	public void  restart()
	{
		Time.timeScale = 1;

		SceneManager.LoadScene ("Snow");
	}
	public void MainMenu()
	{
		Time.timeScale = 1;
		SceneManager.LoadScene("MainMenu");
	}

	public void Next ()
	{
		tounlock=PlayerPrefs.GetInt ("LevelNo");
		nextLevel = PlayerPrefs.GetInt ("LevelNo",2);
		tounlock += 1;
		nextLevel += 1;
		if (nextLevel < 5) {
			PlayerPrefs.SetInt ("SnowLevelNo", nextLevel);
			PlayerPrefs.SetInt ("unlocksnow", tounlock);

			SceneManager.LoadScene ("Snow");
			Time.timeScale = 1;
		} else {
			SceneManager.LoadScene ("MainMenu");

		}
	}

	void Update () {

	}
}
