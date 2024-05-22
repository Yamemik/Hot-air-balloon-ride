using UnityEngine;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{
    public static GameManagerScript instance;
    public static int points = 100;

    void Awake()
    {
        if (!instance)
        {
            instance = this;
            DontDestroyOnLoad(transform.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void OnLevelWasLoaded(int level)
    {
        Text ui = GameObject.Find("/Canvas/Text").GetComponent<Text>();
        Debug.Log("scene was loaded");
    }
}