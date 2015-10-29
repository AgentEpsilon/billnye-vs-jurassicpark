using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TreeMinigamePC : MonoBehaviour {

	private bool right = false;
	private bool finish = false;
	private readonly int displacement = 1;
	public float completed {get; private set;}
	[SerializeField] public Slider progress;
	[SerializeField] public GameObject victory;
	
	// Update is called once per frame
	void Update () {
		if(!finish){
			if(Input.GetAxis("Horizontal")>0&&!right){
				transform.Translate(transform.right*displacement);
				right = !right;
				completed = Mathf.Min (completed+5f, 100f);
			}else if(Input.GetAxis("Horizontal")<0&&right){
				transform.Translate(-transform.right*displacement);
				right = !right;
				completed = Mathf.Min (completed+5f, 100f);
			}
			completed = Mathf.Max(completed-Time.deltaTime*20f, 0f);
			progress.value = completed;
			if(completed>95f){
				finish = true;
				victory.SetActive(true);
			}
		}
	}
}
