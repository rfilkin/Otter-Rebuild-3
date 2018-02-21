using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerLinkWithRunes : MonoBehaviour {

	[SerializeField] List<GameObject> linkedUpnodes;
	[SerializeField] bool isPowered = false;

	[SerializeField] List<PowerSymbol> powerSymbols = new List<PowerSymbol>();

	public List<GameObject> GetAttachedOutNodes(){
		return linkedUpnodes;
	}

	public void SetPower(bool powerState){
		isPowered = powerState;
		UpdateLines();
	}

	public bool IsPowered(){
		return isPowered;
	}

	void UpdateLines(){
		if (isPowered)
			SetPowerLines(true);
		else
			SetPowerLines(false);
	}

	void SetPowerLines(bool on){
		foreach (PowerSymbol line in powerSymbols)
			line.SetPowered(on);
	}
}
