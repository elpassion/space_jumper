using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets._2D
{
    [RequireComponent(typeof (PlatformerCharacter2D))]
    public class Platformer2DUserControl : MonoBehaviour
    {
        private PlatformerCharacter2D m_Character;
        private bool m_Jump;
		private bool m_SwtichGravity;
		private bool m_isSwipe;
		private Vector2 touchStartingPosition;

        private void Awake()
        {
            m_Character = GetComponent<PlatformerCharacter2D>();
        }

        private void Update()
        {
            if (!m_Jump) {
				m_Jump = CrossPlatformInputManager.GetButtonDown("Fire1");
			}

			if (!m_SwtichGravity) {
				m_SwtichGravity = CrossPlatformInputManager.GetButtonDown("Fire2");
			}

			UpdateTouches();
        }

        private void FixedUpdate()
        {
			if (m_Jump)
				m_Character.Jump();

			if (m_SwtichGravity)
				m_Character.SwitchGravity();

			m_Jump = false;
			m_SwtichGravity = false;
        }

		private void UpdateTouches()
		{
			if (Input.touches.Length > 0) {
				Touch touch = Input.GetTouch (0);
				
				switch (touch.phase) {
				case TouchPhase.Began:
					m_isSwipe = true;
					touchStartingPosition = touch.position;
					break;
				case TouchPhase.Ended:
					m_Jump = true;
					m_isSwipe = false;
					break;
				case TouchPhase.Moved:
					Vector2 currentSwipe = touch.position - touchStartingPosition;
					if (currentSwipe.magnitude > 10f && m_isSwipe) {
						m_SwtichGravity = true;
						m_isSwipe = false;
					}
					break;
				}
			}
		}
    }
}