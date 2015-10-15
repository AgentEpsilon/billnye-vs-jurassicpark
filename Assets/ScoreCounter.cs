using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BoneCount : MonoBehaviour {

	int count;
	Text score;

	void Start(){
		count = 0;
		score = GetComponent<Text> ();
	}

	
	public void incCount(string resource){
		count++;
		score.text = resource + ": " + count.ToString ();
	}
}
