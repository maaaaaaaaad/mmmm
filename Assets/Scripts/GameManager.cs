using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public static GameManager GetInstance() => _instance;

    private void Awake()
    {
        if (_instance != null)
            return;

        var go = GameObject.Find("@Manager");
        if (go == null)
        {
            go = new GameObject { name = "@Manager" };
            _instance = go.AddComponent<GameManager>();
        }
        else
        {
            DontDestroyOnLoad(go);
            _instance = go.GetComponent<GameManager>();
        }
    }

    private void OnDestroy()
    {
        if (_instance == this)
            _instance = null;
    }
}