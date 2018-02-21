using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerSymbol : MonoBehaviour {

	[SerializeField] Color onColor = Color.cyan;
	[SerializeField] Color offColor = Color.black;
	[SerializeField] Transform center;

	[SerializeField] float pulseSpeed = 0.02f;	//units per second
	[SerializeField] float pulsesPerMinute = 12f;

	LineRenderer line;
	float secondsPerPulse;
	float timeFromCenter;

	// Use this for initialization
	void Start () {
		line = GetComponentInChildren<LineRenderer>();
		secondsPerPulse = 60f / pulsesPerMinute;
		//timeFromCenter = TimeFromCenter();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//temporary; sets the color of the line renderer to reflect whether it is on or off
	public void SetPowered(bool on){
		if(on)
			line.startColor = line.endColor = onColor;
		else
			line.startColor = line.endColor = offColor;
	}

	void Flickering(){

	}

	/*
	void PowerPulse(){
		//these are done in local space
		Vector3 start = line.GetPosition(0);
		Vector3 end = line.GetPosition(1);	//assuming the line has only one segment

		float pulseTime = PulseTime();	//creates a timeframe between 0 and secondsPerPulse

		//print(start);
		//print(end);

		//line.endColor
	}
	*/

	//returns the time offset that this wave experiences from the wave traveling from the center
	float TimeFromCenter(){
		return (transform.position - center.position).magnitude * pulseSpeed;
	}

	//returns the current time for the waveform, minus the delay for the travel time from the center
	float PulseTime(){
		return (Time.time - timeFromCenter) % secondsPerPulse;
	}
}
