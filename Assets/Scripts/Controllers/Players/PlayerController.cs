using Managers;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Controllers.Players
{
    public class PlayerController : MonoBehaviour
    {
        private const float MoveSpeed = 2f;
        private const float RotationSpeed = 20f;
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
                direction += Vector3.forward;

            if (Keyboard.current.sKey.isPressed)
                direction += Vector3.back;

            if (Keyboard.current.aKey.isPressed)
                direction += Vector3.left;

            if (Keyboard.current.dKey.isPressed)
                direction += Vector3.right;

            if (direction == Vector3.zero)
                return;

            direction.Normalize();

            var targetRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(
                transform.rotation,
                targetRotation,
                Time.deltaTime * RotationSpeed
            );

            transform.Translate(Vector3.forward * (Time.deltaTime * MoveSpeed));
        }
    }
}