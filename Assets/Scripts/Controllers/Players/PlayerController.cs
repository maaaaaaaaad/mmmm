using UnityEngine;

namespace Controllers.Players
{
    public class PlayerController : MonoBehaviour
    {
        private GameManager _getGameManager;

        private void Start()
        {
            _getGameManager = GameManager.GetInstance();
            Debug.Log($"Player started instance of {_getGameManager.gameObject}");
        }
    }
}