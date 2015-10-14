using UnityEngine;
using System.Collections;

public class ControlBill : MonoBehaviour {

	public float speed;
	private Animator anim;
	private Rigidbody2D rigidbody2D;
	
	[SerializeField] private float horiz;
	[SerializeField] private float verti;

	void Start(){
		anim = GetComponent<Animator> ();
		rigidbody2D = GetComponent<Rigidbody2D> ();
	}
	
	void Update () {
		horiz = Input.GetAxis ("Horizontal");
		verti = Input.GetAxis ("Vertical");
		rigidbody2D.velocity = new Vector2(Mathf.Lerp(0, horiz* speed, 0.8f),
		                                   Mathf.Lerp(0, verti* speed, 0.8f));
		if (horiz != 0f || verti != 0f)
			anim.SetBool ("isWalking", true);
		else
			anim.SetBool ("isWalking", false);
	}
}
