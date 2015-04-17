using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimeMode : MonoBehaviour {
	private float time;
	private Text txt;

	void Start () {
		time = 0.0F;
		txt = gameObject.GetComponent<Text>(); 
		txt.text = ((int) time).ToString();
	}
	
	void Update () {
		time += UnityEngine.Time.deltaTime;
		txt.text = ((int) time).ToString();
		PlayerPrefs.SetInt ("time", (int)time);
	}
}
