using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Progress : MonoBehaviour {
	private float height;
	private RectTransform rectTransform;
	private float progress;
	private float distance;
	private float playerStartPosition;

	public Transform player;

	public Transform endZone;
	
	// Use this for initialization
	void Start () {
		rectTransform = gameObject.GetComponent<RectTransform>();
		height = rectTransform.rect.height;
		playerStartPosition = player.position.x;
		distance = (endZone.position.x - playerStartPosition);
		progress = (player.position.x - playerStartPosition) / distance * 490;
	}
	
	// Update is called once per frame
	void Update () {
		progress = (player.position.x - playerStartPosition) / distance * 490;
		rectTransform.sizeDelta = new Vector2(progress, height);
	}
}
