using System;
using UnityEngine;

namespace UnityStandardAssets._2D
{
    public class PlatformerCharacter2D : MonoBehaviour
    {
        [SerializeField] private float m_MaxSpeed = 10f;                    // The fastest the player can travel in the x axis.
        [SerializeField] private float m_JumpForce = 400f;                  // Amount of force added when the player jumps.
        [Range(0, 1)] [SerializeField] private float m_CrouchSpeed = .36f;  // Amount of maxSpeed applied to crouching movement. 1 = 100%
        [SerializeField] private LayerMask m_WhatIsGround;                  // A mask determining what is ground to the character

        private Transform m_GroundCheck;    // A position marking where to check if the player is grounded.
        const float k_GroundedRadius = .2f; // Radius of the overlap circle to determine if grounded
        private bool m_Grounded;            // Whether or not the player is grounded.
        private Transform m_CeilingCheck;   // A position marking where to check for ceilings
        const float k_CeilingRadius = .01f; // Radius of the overlap circle to determine if the player can stand up
        private Animator m_Anim;            // Reference to the player's animator component.
        private Rigidbody2D m_Rigidbody2D;
        private bool m_FacingRight = true;  // For determining which way the player is currently facing.

        private void Awake()
        {
            // Setting up references.
            m_GroundCheck = transform.Find("GroundCheck");
            m_CeilingCheck = transform.Find("CeilingCheck");
            m_Anim = GetComponent<Animator>();
            m_Rigidbody2D = GetComponent<Rigidbody2D>();
			m_Rigidbody2D.gravityScale = 0;
        }

        private void FixedUpdate()
        {
			Collider2D[] colliders = Physics2D.OverlapCircleAll(m_GroundCheck.position, k_GroundedRadius, m_WhatIsGround);
			for (int i = 0; i < colliders.Length; i++)
			{
				if (colliders[i].gameObject != gameObject)
					m_Grounded = true;
			}
			Debug.Log (m_Grounded);
			m_Rigidbody2D.AddForce(Physics2D.gravity);
            m_Rigidbody2D.velocity = new Vector2(1*m_MaxSpeed, m_Rigidbody2D.velocity.y);
			if (m_Grounded)
           	{
	            m_Rigidbody2D.AddForce(new Vector2(0f, m_JumpForce));
                m_Grounded = false;
            }
        }



//        public void Move(bool jump)
//        {
//            
//            //only control the player if grounded or airControl is turned on
//            if (m_Grounde zd || m_AirControl)
//            {
//                // The Speed animator parameter is set to the absolute value of the horizontal input.
//                m_Anim.SetFloat("Speed", Mathf.Abs(move));
//                // Move the character
//                m_Rigidbody2D.velocity = new Vector2(move*m_MaxSpeed, m_Rigidbody2D.velocity.y);
//            }
//            // If the player should jump...
//            if (m_Grounded && jump && m_Anim.GetBool("Ground"))
//            {
//                // Add a vertical force to the player.
//                m_Grounded = false;
//                m_Anim.SetBool("Ground", false);
//                m_Rigidbody2D.AddForce(new Vector2(0f, m_JumpForce));
//            }
//        }
    }
}
