using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SpeedMeter : MonoBehaviour {
	private float speed;
	private Text txt;

	public Rigidbody2D player;
	
	void Start () {
		speed = 0.0F;
		txt = gameObject.GetComponent<Text>(); 
		txt.text = ((int) speed).ToString();
	}
	
	void Update () {
		speed = player.velocity.x * 5;
		txt.text = ((int) speed).ToString();
	}
}
