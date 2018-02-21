using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteCombo : MonoBehaviour {

	[SerializeField] GameObject finalTriggerArea;

	public void Complete(){
		foreach(Box b in FindObjectsOfType<Box>())
			b.Disable();
		finalTriggerArea.SetActive(true);
	}
}
