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

	public int buttonFontSize;
	public string buttonFont;


	void OnGUI(){

		// Display our Buttons

		GUI.skin.button.normal.background = (Texture2D) buttonTexture;
		GUI.skin.button.hover.background = (Texture2D) buttonTexture;
		GUI.skin.button.active.background = (Texture2D) buttonTexture;

		GUIStyle menuButtonStyle = new GUIStyle(GUI.skin.button);

		menuButtonStyle.fontSize = buttonFontSize;
		menuButtonStyle.font = (Font)Resources.Load(buttonFont, typeof(Font));
		menuButtonStyle.normal.textColor = Color.white;

		if (GUI.Button (new Rect(Screen.width * startButtonXPosition, Screen.height * startButtonYPosition, Screen.width * startButtonWidth, Screen.height * startButtonHeight), "", menuButtonStyle)) {
			Application.LoadLevel ("timemode");
		}
	}
}
