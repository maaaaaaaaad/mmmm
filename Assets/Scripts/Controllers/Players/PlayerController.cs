using UnityEngine;
using UnityEngine.InputSystem;

namespace Controllers.Players
{
    public class PlayerController : MonoBehaviour
    {
        private const float MoveSpeed = 2f;
        private GameManager _getGameManager;

        private void Start()
        {
            _getGameManager = GameManager.GetInstance();
        }

        private void Update()
        {
            OnMove();
        }

        private void OnMove()
        {
            var direction = Vector3.zero;

            if (Keyboard.current.wKey.isPressed)
                direction += transform.forward;

            if (Keyboard.current.sKey.isPressed)
                direction -= transform.forward;

            if (Keyboard.current.aKey.isPressed)
                direction -= transform.right;

            if (Keyboard.current.dKey.isPressed)
                direction += transform.right;

            if (direction != Vector3.zero)
                direction.Normalize();

            transform.position += direction * (Time.deltaTime * MoveSpeed);
        }
    }
}