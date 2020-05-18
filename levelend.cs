using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelend : MonoBehaviour {



	public GameObject Next;



	void OnTriggerEnter(Collider any)
	{
		if (any.gameObject.CompareTag("Player"))
		{
			Debug.Log ("Level End");

			Next.SetActive (true);
			Time.timeScale = 0;
		}
	}



	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
}
