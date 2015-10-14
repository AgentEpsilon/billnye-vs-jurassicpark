using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour {

	int count;
	Text score;

	void Start(){
		count = 0;
		score = GetComponent<Text> ();
	}

	
	public void incCount(){
		count++;
		score.text = "Bones: " + count.ToString ();
	}
}
