using System;
using UnityEngine;

namespace ShootEmUp
{
    public class KeyboardInputHandler : IInputHandler
    {
        public event Action OnFirePressed;

        public float GetMoveDirection()
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                return -1;
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                return 1;
            }
            return 0;
        }
        
        public void ProcessInput()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                OnFirePressed?.Invoke();
            }
        }
    }
}