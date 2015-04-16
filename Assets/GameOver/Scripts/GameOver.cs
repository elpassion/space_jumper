/// <summary>
/// Game over.
/// Attached to Main Camera
/// </summary>
using UnityEngine;
using System;
using System.Collections;

public class GameOver : MonoBehaviour {

	public Texture backgroundTexture;

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

	void OnGUI(){

		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), backgroundTexture);
		
		GUIStyle labelStyle = new GUIStyle(GUI.skin.label);

		labelStyle.fontSize = fontSize;
		labelStyle.font = (Font)Resources.Load(font, typeof(Font));
		labelStyle.normal.textColor = Color.white;

		int time = PlayerPrefs.GetInt ("time");

		GUI.Label (new Rect (Screen.width * gameOverLabelXPosition, Screen.height * gameOverLabelYPosition, Screen.width * gameOverLabelWidth, Screen.height * gameOverLabelHeight), "Game Over!", labelStyle);
		GUI.Label (new Rect (Screen.width * timeLabelXPosition, Screen.height * timeLabelYPosition, Screen.width * timeLabelWidth, Screen.height * timeLabelHeight), String.Concat("Time: ", time, "s"), labelStyle);
	}
}
