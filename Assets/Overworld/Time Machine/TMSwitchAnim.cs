using UnityEngine;
using System.Collections;

public class TMSwitchAnim : MonoBehaviour {

	private Animator anim;

	void Start() {
		anim = GetComponent<Animator> ();
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			if(anim.GetCurrentAnimatorStateInfo(0).IsName("Off")){
				anim.CrossFade("On", 0f);
			}else{
				anim.CrossFade("Off", 0f);
			}
		}
	}
}
