using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mirrorEndLogic : MonoBehaviour {

	public starLogic star1;
	public starLogic star2;
	public starLogic star3;
	public starLogic star4;
	public starLogic star5;
    bool triggered = false;
    public Sprite openDoor;
    public Sprite closedDoor;

	bool loadingNextScene = false;
	SpriteRenderer ren;

    void OnTriggerEnter2D(Collider2D col)
    {
		if (triggered && col.tag == "Player" && !loadingNextScene)
			loadingNextScene = Statics.TryLoadNextScene();
    }

    // Use this for initialization
    void Start () {
		ren = GetComponent<SpriteRenderer>();
		ren.sprite = closedDoor;
    }
	
	// Update is called once per frame
	void Update () {
        if (star1.active
            && star2.active
            && star3.active
            && star4.active
            && star5.active)
        {
            ren.sprite = openDoor; //open the door
            triggered = true;
        }
        else
        {
            ren.sprite = closedDoor; //close the door
            triggered = false;
        }
    }
}
