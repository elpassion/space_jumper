using System;
using UnityEngine;

namespace UnityStandardAssets._2D
{
    public class Camera2DFollow : MonoBehaviour
    {
        public Transform player;
        
        private void Update()
        {
			transform.position = new Vector3(player.position.x + 2.0f, transform.position.y, transform.position.z);
        }
    }
}
