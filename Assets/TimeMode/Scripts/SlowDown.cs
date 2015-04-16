using UnityEngine;
using System.Collections;
using UnityStandardAssets._2D;

public class SlowDown : MonoBehaviour {
	
	private void OnTriggerStay2D(Collider2D collider)
	{
		collider.attachedRigidbody.AddForce(new Vector2 (-30f, 0f));
	}
}
