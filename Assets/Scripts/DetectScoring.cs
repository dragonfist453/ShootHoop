using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectScoring : MonoBehaviour {
	public int scorePerHit = 1;

	void OnCollisionEnter(Collision collision){
		ScoreKeeper scoreKeep = FindObjectOfType<ScoreKeeper> ();
		scoreKeep.IncrementScore(scorePerHit);
	}
}
