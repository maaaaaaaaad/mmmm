using UnityEngine;
using UnityEngine.InputSystem;

namespace Controllers.Players
{
    public class PlayerController : MonoBehaviour
    {
        private GameManager _getGameManager;

        private void Start()
        {
            _getGameManager = GameManager.GetInstance();
        }

        private void Update()
        {
            if (Keyboard.current.wKey.isPressed)
            {
                Debug.Log("Player is moving forward");
            }
        }
    }
}