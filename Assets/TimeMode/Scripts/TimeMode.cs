using UnityEngine;
using System;
using System.Collections;

public class TimeMode : MonoBehaviour {

	public float timeLabelXPosition;
	public float timeLabelYPosition;
	public float timeLabelWidth;
	public float timeLabelHeight;

	public int fontSize;
	public string font;

	private float time;
	private string timerLabel;

	void OnGUI(){

		GUIStyle labelStyle = new GUIStyle(GUI.skin.label);
		
		labelStyle.fontSize = fontSize;
		labelStyle.font = (Font)Resources.Load(font, typeof(Font));
		labelStyle.normal.textColor = Color.white;
		
		GUI.Label (new Rect (Screen.width * timeLabelXPosition, Screen.height * timeLabelYPosition, Screen.width * timeLabelWidth, Screen.height * timeLabelHeight), timerLabel, labelStyle);
	}

	// Use this for initialization
	void Start () {
		time = 0.0F;
		timerLabel = "Time: 0s";
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		PlayerPrefs.SetInt("time", (int) time);
		timerLabel = String.Concat("Time: ", (int) time, "s");
	}
}
