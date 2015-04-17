/// <summary>
/// Game over.
/// Attached to Main Camera
/// </summary>
using UnityEngine;
using System;
using System.Collections;

public class GameOver : MonoBehaviour {

	public float gameOverLabelXPosition;
	public float gameOverLabelYPosition;
	public float gameOverLabelWidth;
	public float gameOverLabelHeight;

	public float timeLabelXPosition;
	public float timeLabelYPosition;
	public float timeLabelWidth;
	public float timeLabelHeight;

	public int fontSize;
	public string font;

	public Texture2D retryButtonTexture;
	public float retryButtonXPosition;
	public float retryButtonYPosition;
	public float retryButtonWidth;
	public float retryButtonHeight;

	public Texture2D menuButtonTexture;
	public float menuButtonXPosition;
	public float menuButtonYPosition;
	public float menuButtonWidth;
	public float menuButtonHeight;

	void OnGUI(){

		GUIStyle retryButtonStyle = new GUIStyle(GUI.skin.button);

		retryButtonStyle.normal.background = (Texture2D) retryButtonTexture;
		retryButtonStyle.hover.background = (Texture2D) retryButtonTexture;
		retryButtonStyle.active.background = (Texture2D) retryButtonTexture;

		if (GUI.Button (new Rect(Screen.width * retryButtonXPosition, Screen.height * retryButtonYPosition, Screen.width * retryButtonWidth, Screen.height * retryButtonHeight), "", retryButtonStyle)) {
			Application.LoadLevel ("timemode");
		}

		GUIStyle menuButtonStyle = new GUIStyle(GUI.skin.button);
		
		menuButtonStyle.normal.background = (Texture2D) menuButtonTexture;
		menuButtonStyle.hover.background = (Texture2D) menuButtonTexture;
		menuButtonStyle.active.background = (Texture2D) menuButtonTexture;

		if (GUI.Button (new Rect(Screen.width * menuButtonXPosition, Screen.height * menuButtonYPosition, Screen.width * menuButtonWidth, Screen.height * menuButtonHeight), "", menuButtonStyle)) {
			Application.LoadLevel ("mainmenu");
		}
	}	
}
