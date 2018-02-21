using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevertGravityZone : MonoBehaviour {

	LayerMask playerLayer;
	LayerMask boxLayer;

	void Start(){
		playerLayer = LayerMask.NameToLayer("Player");
		boxLayer = LayerMask.NameToLayer("Box");
	}

	void OnTriggerExit2D(Collider2D col){

		int objLayer = col.gameObject.layer;

		if (objLayer == playerLayer || objLayer == boxLayer){
			CentralGravity cg = col.GetComponent<CentralGravity>();
			//print(col.gameObject.name);
			cg.RightsideUp();
		}
	}
}
