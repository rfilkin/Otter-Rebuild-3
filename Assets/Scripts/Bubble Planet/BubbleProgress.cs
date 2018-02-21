using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BubbleProgress : MonoBehaviour {

	[SerializeField] List<BoxLock> lockers = new List<BoxLock>();

	void Start(){
		print(Statics.currentScene);
		foreach(BoxLock part in lockers){
			part.InitPuzzleManager(this);
		}
	}

	//-------------------------------------------------------------------------------
	//returns the number of completed parts of the puzzle
	//-------------------------------------------------------------------------------

	public int LockedBoxCount(){
		int count = 0;
		foreach (BoxLock part in lockers){
			if (part.GetComplete())
				++count;
		}
		return count;
	}

	//-------------------------------------------------------------------------------
	//checks if all of the parts of this puzzle are complete
	//-------------------------------------------------------------------------------
	public void CheckSolution(){
		foreach(BoxLock part in lockers){
			if (!part.GetComplete())
				return;
		}
		OnComplete();
	}
		
	//-------------------------------------------------------------------------------
	//will need to begin the transition cutscene; but for now just switches the scene
	//-------------------------------------------------------------------------------
	void OnComplete(){
		print("Called");
		if (!Statics.TryLoadNextScene()){
			return;	//if false, this is the last scene
		}
	}
}
