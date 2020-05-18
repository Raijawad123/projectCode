using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GotoNextLevel : MonoBehaviour {


		public int nextSceneLoad;

	// Use this for initialization
	void Start () {

		nextSceneLoad = SceneManager.GetActiveScene().buildIndex +1;
		
	}

	public void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.tag == "Player")
		{
			//move to next level
			SceneManager.LoadScene(nextSceneLoad);

			//Setting Int for index

			if (nextSceneLoad > PlayerPrefs.GetInt("LevelNo"))
			{
				PlayerPrefs.SetInt("LevelNo",nextSceneLoad);
			}
		}	
	}
	
	
}
