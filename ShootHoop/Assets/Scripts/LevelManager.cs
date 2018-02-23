using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
	int currentIndex =	SceneManager.GetActiveScene ().buildIndex;
	// Use this for initialization
	void Start ()
	{



	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown ("space"))
			SceneManager.LoadScene (currentIndex + 1);
	}
		
}
