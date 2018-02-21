using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerCutsceneZone : MonoBehaviour {

	[SerializeField] UnityEvent triggerEvent;

	bool triggered = false;

	void OnTriggerEnter2D(){
		if (!triggered){
			print("Trigger Entered");
			triggerEvent.Invoke();
			triggered = true;
		}
	}

	public void NextScene(){
		if (!(triggered = Statics.TryLoadNextScene())){
			return;	//if false, this is the last scene
		}
	}

}
