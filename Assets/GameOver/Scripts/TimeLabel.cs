using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimeLabel : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int time = PlayerPrefs.GetInt ("time");
		
		Text txt = gameObject.GetComponent<Text>(); 
		txt.text = ((int) time).ToString();
	}
}
