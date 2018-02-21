using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrierLogic : MonoBehaviour {

    public GameObject leftMirror;
    public GameObject rightMirror;
    public Sprite openGate;
    public Sprite closedGate;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(leftMirror.GetComponent<mirrorLogic>().mirrorState == 1 || rightMirror.GetComponent<mirrorLogic>().mirrorState == 0)
        {
            //if leftMirror faces right, or rightMirror faces left, 
            //turn off rendering and collision
            //GetComponent<Renderer>().enabled = false;
            GetComponent<BoxCollider2D>().enabled = false;
            GetComponent<SpriteRenderer>().sprite = openGate; //open the gate

        }
        else
        {
            //else, 
            //turn on rendering and collision
            //GetComponent<Renderer>().enabled = true;
            GetComponent<BoxCollider2D>().enabled = true;
            GetComponent<SpriteRenderer>().sprite = closedGate; //close the gate
        }
    }
}
