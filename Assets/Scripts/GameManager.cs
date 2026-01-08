using UnityEngine;

public class GameManager : MonoBehaviour
{
    private const string InstanceName = "@Manager";
    private static GameManager _instance;
    public static GameManager GetInstance() => _instance;

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Init()
    {
        if (_instance != null)
            return;

        var go = GameObject.Find(InstanceName);
        if (go == null)
        {
            go = new GameObject { name = InstanceName };
            _instance = go.AddComponent<GameManager>();
        }
        else
        {
            _instance = go.GetComponent<GameManager>();
            DontDestroyOnLoad(go);
        }
    }

    private void OnDestroy()
    {
        if (_instance == this)
            _instance = null;
    }
}