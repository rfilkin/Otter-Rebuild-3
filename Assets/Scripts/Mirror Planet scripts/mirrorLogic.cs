using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mirrorLogic : MonoBehaviour {

    static KeyCode interactButton = KeyCode.Q;

    public int mirrorState; //0 is left, 1 is right, 2 is neutral
    SpriteRenderer sprite;
    float rightOffset;
    bool flipNow = false;
    public bool playerOnMirror = false;
    //float timer = 0f;

    // Use this for initialization
    void Start () {
        sprite = GetComponent<SpriteRenderer>();
        //rightOffset = transform.localPosition.x;
        rightOffset = 0;
        //initMirrorState = initMirrorState;
	}

    // Update is called once per frame
    void Update()
    {
        if (playerOnMirror && Input.GetKeyDown(interactButton) && !flipNow)
        {
            flipNow = true;
            mirrorState = (mirrorState + 1) % 3;
            setPosition();

            //when button is pressed, cycle through 3 positions for the mirror: left (0), right (1), and neutral(2)(towards objective).
        }
        setPosition();
    }

    void OnTriggerStay2D(Collider2D col)
    {
        //print("called");
        if (col.gameObject.tag == "Player")
        {
            playerOnMirror = true;
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            playerOnMirror = false;
        }
    }

    void setPosition()
    {
        if (mirrorState == 0 && flipNow)
        {
            //transform.localPosition = new Vector2(rightOffset, transform.localPosition.y);
            //sprite.flipX = true;
            flipNow = false;
            //print("flipped to left position");
        }
        else if (mirrorState == 1 && flipNow)
        {
            //transform.localPosition = new Vector2(-rightOffset, transform.localPosition.y);
            //sprite.flipX = false;
            flipNow = false;
            //print("flipped to right position");
        }
        else if (mirrorState == 2 && flipNow)
        {
            flipNow = false;
        }
        else if (flipNow)
        {
            //print("error: mirror position is invalid");
            //print("init state: " + initMirrorState);
            //print("current state: " + mirrorState);
        }
        else if (!flipNow)
        {
            //timer = 0f;
        }
    }

}
