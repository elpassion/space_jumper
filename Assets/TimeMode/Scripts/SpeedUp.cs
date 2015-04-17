using UnityEngine;
using System.Collections;
using UnityStandardAssets._2D;

public class SpeedUp : MonoBehaviour {

	private void OnTriggerStay2D(Collider2D collider)
	{
		collider.attachedRigidbody.AddForce(new Vector2 (75f, 0f));
	}
}
