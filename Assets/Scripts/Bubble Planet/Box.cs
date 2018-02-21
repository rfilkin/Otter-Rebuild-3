using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour {

	CentripetalCounter cc;
	CentralGravity grav;
	Rigidbody2D body;
	//Collider2D[] cols;

	// Use this for initialization
	void Start () {
		cc = GetComponent<CentripetalCounter>();
		grav = GetComponent<CentralGravity>();
		body = GetComponent<Rigidbody2D>();
		//cols = GetComponents<Collider2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Disable(){
		gameObject.layer = LayerMask.NameToLayer("Ignore Planet Collision");
		cc.enabled = false;
		grav.enabled = false;
		body.velocity = Vector2.zero;
		body.isKinematic = true;
	}
}
