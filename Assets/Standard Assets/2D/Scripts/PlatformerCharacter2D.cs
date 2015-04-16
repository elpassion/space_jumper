using System;
using UnityEngine;

namespace UnityStandardAssets._2D
{
    public class PlatformerCharacter2D : MonoBehaviour
    {
		[SerializeField] private float m_Speed = 10f;
        [SerializeField] private float m_JumpForce = 400f;
        [SerializeField] private LayerMask m_WhatIsGround;

        private bool m_Grounded;
        private Rigidbody2D m_Rigidbody2D;
		private Collider2D m_Collider;

        private void Awake()
        {
            m_Rigidbody2D = GetComponent<Rigidbody2D>();
			m_Collider = GetComponent<Collider2D>();
			m_Rigidbody2D.gravityScale = 0;
        }

        private void FixedUpdate()
        {
			m_Grounded = m_Collider.IsTouchingLayers(m_WhatIsGround);
			m_Rigidbody2D.AddForce(Physics2D.gravity);
			m_Rigidbody2D.velocity = new Vector2(m_Speed, m_Rigidbody2D.velocity.y);
        }

        public void Jump()
        {
			if (m_Grounded)
			{
				m_Rigidbody2D.AddForce(new Vector2(0f, m_JumpForce));
				m_Grounded = false;
			}
        }
    }
}