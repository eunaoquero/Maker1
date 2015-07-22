using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour {

	public Animator handClip;


	private string labeltext = "Unassemble";
	private bool assembled = true;
	private bool firstPush = false;
	// Use this for initialization
	void Start () {

		handClip.speed = 0;

//		Animator
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){

		GUI.skin.button.fontSize = (int) (Screen.width/55 + Screen.height/55);
		
		if (GUI.Button(new Rect((Screen.width/30),(Screen.height/30),(Screen.width/30) * 5  ,(Screen.height/30)*2 ), labeltext)){

			if (!firstPush){
				firstPush = true;
				handClip.Play(0);
			}


			if (assembled){
				labeltext = "Assemble";
				handClip.speed = 1.0f;
				assembled = false;
					} else {
				labeltext = "Unassemble";
				handClip.speed = -1.0f;
				
				
				assembled = true;

				//		handClip.transform.animation["Take 001"].speed = -1.0f;

			}
		}



	}



}



