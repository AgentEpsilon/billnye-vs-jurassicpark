﻿using UnityEngine;
using System.Collections;

public class TMSwitchAnim : MonoBehaviour {

	private Animator anim;

	void Start() {
		anim = GetComponent<Animator> ();
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			if (anim.GetCurrentAnimatorStateInfo (0).IsName ("Off")) {
				anim.CrossFade ("On", 0f);
			} else {
				anim.CrossFade ("Off", 0f);
			}
		}
		if (Input.GetKeyDown (KeyCode.H)) {
			PDM.instance.health -= 1;
		}
		if (Input.GetKeyDown (KeyCode.G)) {
			PDM.instance.health += 1;
		}
	}
}
