/// <summary>
/// Main menu.
/// Attached to Main Camera
/// </summary>
using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	public Texture backgroundTexture;

	public float startButtonXPosition;
	public float startButtonYPosition;

	public float startButtonWidth;
	public float startButtonHeight;

	public int buttonFontSize;
	public string buttonFont;


	void OnGUI(){

		// Display our Background Texture
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), backgroundTexture);

		// Display our Buttons

		GUIStyle menuButtonStyle = new GUIStyle(GUI.skin.button);

		menuButtonStyle.fontSize = buttonFontSize;
		menuButtonStyle.font = (Font)Resources.Load(buttonFont, typeof(Font));
		menuButtonStyle.normal.textColor = Color.white;

		if (GUI.Button (new Rect(Screen.width * startButtonXPosition, Screen.height * startButtonYPosition, Screen.width * startButtonWidth, Screen.height * startButtonHeight), "Play", menuButtonStyle)) {
			print ("Clicked Play button");
			// Application.LoadLevel ('level1');
		}
	}
}
