using UnityEngine;

namespace Players
{
    public class Player : MonoBehaviour
    {
        private GameManager _getGameManager;

        private void Start()
        {
            _getGameManager = GameManager.GetInstance();
        }
    }
}