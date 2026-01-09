using System;
using UnityEngine.InputSystem;

namespace Managers
{
    public class InputManager
    {
        public readonly Action MoveKeyAction = null;

        private void OnEnable()
        {
            if (!Keyboard.current.anyKey.isPressed)
                return;

            MoveKeyAction?.Invoke();
        }
    }
}