using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour {
	Text text;

	void Start() {
		text = GetComponent<Text>();
	}
	
	void Update() {
		int score = FindObjectOfType<ScoreKeeper>().score;
		text.text = "Score: " + score;
	}
}
