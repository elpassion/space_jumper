using UnityEngine;
using System.Collections;

public class Finish : MonoBehaviour {

	private void OnTriggerEnter2D(Collider2D other)
	{
		Application.LoadLevel ("gameover");
	}
}