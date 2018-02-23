using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
	
	// Use this for initialization
	void Start ()
	{



	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown ("space"))
			LoadNextScene ();

	}

	public void LoadNextScene () {
		int currentIndex =	SceneManager.GetActiveScene ().buildIndex;
		SceneManager.LoadScene (currentIndex + 1);
	}

	public void PreviousScene () {
		int currentIndex =	SceneManager.GetActiveScene ().buildIndex;
		SceneManager.LoadScene (currentIndex - 1);
	}
		
}
