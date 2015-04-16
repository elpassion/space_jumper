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
    }
}