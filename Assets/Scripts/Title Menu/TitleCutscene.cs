using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleCutscene : MonoBehaviour {

	[SerializeField] float cutsceneDelay;

	[SerializeField] GameObject exhaust;
	[SerializeField] GameObject spaceShip;

	[SerializeField] float shipRumbleAmplitude;

	[SerializeField] float engineFlickerDuration;
	[SerializeField] float flickerSpeed;	//defines the period
	[SerializeField] float flickerDurationPercent;	//how long the fire should be out in each period
	[SerializeField] float flickerDecay;	//increases the duration and the speed

	[SerializeField] float fallPhaseDuration;
	[SerializeField] float fallAcceleration;
	[SerializeField] float fallRotation;

	float timer = -1f;
	
	// Update is called once per frame
	void Update () {
		if (timer >= 0){
			timer += Time.deltaTime;
			RunCutscene();
		} else{
			Idle();
		}
	}

	void Idle(){

	}

	void ShipRumble(){
		Vector2 offset = Random.insideUnitCircle * shipRumbleAmplitude;
	}

	public void StartCutscene(){
		timer = 0f;
	}

	void RunCutscene(){
		if (timer < engineFlickerDuration){
			EngineFlicker();
		} else if(timer < engineFlickerDuration + fallPhaseDuration){
			Fall();
		}
	}

	void EngineFlicker(){
		float flickerTime = timer % flickerSpeed;
		bool isOn = flickerTime / flickerSpeed >= flickerDurationPercent;
		//flickerDurationPercent -= ;
	}

	void Fall(){

	}
}
