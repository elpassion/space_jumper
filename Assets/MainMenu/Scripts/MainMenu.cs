/// <summary>
/// Main menu.
/// Attached to Main Camera
/// </summary>
using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	public Texture2D buttonTexture;

	public float startButtonXPosition;
	public float startButtonYPosition;

	public float startButtonWidth;
	public float startButtonHeight;


	void OnGUI(){

		// Display our Buttons

		GUIStyle menuButtonStyle = new GUIStyle(GUI.skin.button);
		menuButtonStyle.normal.background = (Texture2D) buttonTexture;
		menuButtonStyle.hover.background = (Texture2D) buttonTexture;
		menuButtonStyle.active.background = (Texture2D) buttonTexture;

		if (GUI.Button (new Rect(Screen.width * startButtonXPosition, Screen.height * startButtonYPosition, Screen.width * startButtonWidth, Screen.height * startButtonHeight), "", menuButtonStyle)) {
			Application.LoadLevel ("timemode");
		}
	}
}
