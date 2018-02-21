using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class Statics {
	private static int numberOfScenes = 6;
	public static int currentScene = 0;
	private static List<MonoBehaviour> controlDisablers = new List<MonoBehaviour>();

	//note: edge case - two scripts try to modify the player control at once
	public static bool PlayerHasControl{
		get{
			return controlDisablers.Count <= 0;
		}
	}

	public static void SetPlayerControl(bool enabled, MonoBehaviour source){
		if (enabled){
			if (!controlDisablers.Contains(source))
				return;
			controlDisablers.Remove(source);
		} else{
			if (controlDisablers.Contains(source))
				return;
			controlDisablers.Add(source);
		}
	}

	public static bool TryLoadNextScene(){
		if(currentScene >= SceneManager.sceneCountInBuildSettings){
			return false;
		}
		SceneManager.LoadSceneAsync(++currentScene);
		return true;
	}

	public static void ReloadCurrentScene(){
		SceneManager.LoadSceneAsync(currentScene);
	}

	public static bool TryLoadPreviousScene(){
		if(currentScene <= 0){
			return false;
		}
		SceneManager.LoadSceneAsync(--currentScene);
		return true;
	}
}
