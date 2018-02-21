using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleScreenLogic : MonoBehaviour {

    public Button PlayButton;
    public Button QuitButton;

	bool loadingNextScene = false;

	// Use this for initialization
	void Start () {
        PlayButton = GetComponent<Button> ();
        QuitButton = GetComponent<Button> ();
}

    public void PlayPressed()
    {
		if(!loadingNextScene)
			loadingNextScene = Statics.TryLoadNextScene();
    }
	
    public void QuitPressed()
    {
        Application.Quit();
    }

	// Update is called once per frame
	void Update () {
	}
}
