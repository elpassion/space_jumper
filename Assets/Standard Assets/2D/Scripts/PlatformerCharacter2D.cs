using System;
using UnityEngine;

namespace UnityStandardAssets._2D
{
    public class PlatformerCharacter2D : MonoBehaviour
    {
		[SerializeField] private float m_Speed = 50f;
        [SerializeField] private float m_JumpForce = 400f;
        [SerializeField] private LayerMask m_WhatIsGround;
		[SerializeField] private bool m_Grounded;

        private Rigidbody2D m_Rigidbody2D;
		private Collider2D m_Collider;
		private Transform m_Transform;

        private void Awake()
        {
            m_Rigidbody2D = GetComponent<Rigidbody2D>();
			m_Collider = GetComponent<Collider2D>();
			m_Transform = GetComponent<Transform>();
        }

		private void Update()
		{
			m_Transform.Rotate((new Vector3(0.0f, 0.0f, -20.0f * m_Speed * m_Rigidbody2D.gravityScale) * Time.deltaTime), Space.Self);
		}

        private void FixedUpdate()
        {
			if (PlayerPrefs.GetInt ("time") < 0) {
				FreezePlayer();
			} else {
				UpdateVelocity();	
			}

			m_Grounded = m_Collider.IsTouchingLayers(m_WhatIsGround);
        }

        public void Jump()
        {
			if (m_Grounded) {
				m_Rigidbody2D.AddForce (new Vector2 (0f, m_Rigidbody2D.gravityScale * m_JumpForce));
				m_Grounded = false;
			}
        }

		public void SwitchGravity()
		{
			if (m_Grounded) {
				m_Rigidbody2D.gravityScale *= -1;
				m_Grounded = false;
			}
		}

		private float CalculateVelocityX()
		{
			if (m_Rigidbody2D.velocity.x >= m_Speed) {
				return m_Rigidbody2D.velocity.x - 0.03f * (m_Rigidbody2D.velocity.x - m_Speed);
			}
			else {
				return m_Rigidbody2D.velocity.x + 0.1f * (m_Speed - m_Rigidbody2D.velocity.x);
			}
		}

		private void UpdateVelocity()
		{
			m_Rigidbody2D.velocity = new Vector2(CalculateVelocityX(), m_Rigidbody2D.velocity.y);
		}

		private void FreezePlayer()
		{
			m_Rigidbody2D.velocity = new Vector2(0f, 0f);
		}
    }
}