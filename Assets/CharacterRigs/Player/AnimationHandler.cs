using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHandler : MonoBehaviour {
	
	public Animator animator;
	
	public PlayerJump playerJump;

	// Use this for initialization
	void Start () {
		playerJump = GetComponentInParent<PlayerJump>();
	}
	
	// Update is called once per frame
	void Update () {
		
		//Idle and Walking
		if(Input.GetAxis("Horizontal") != 0 && Statics.PlayerHasControl){
			animator.SetBool("Walking", true);
			if(Input.GetAxis("Horizontal") > 0){
				transform.localScale = new Vector3(0.3f,0.3f,1.0f);
			}
			else if (Input.GetAxis("Horizontal") < 0){
				transform.localScale = new Vector3(-0.3f,0.3f,1.0f);
			}
		}
		else{
			animator.SetBool("Walking", false);
		}
		
		//Grounded and Jumping
		if(playerJump.isGrounded){
			animator.SetBool("Grounded", true);
		}
		if(!playerJump.isGrounded){
			animator.SetBool("Grounded", false);
		}
	}
}
