using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseGame : MonoBehaviour
{
    public void ToMenu()
    {
        SceneManager.LoadScene(0);
    }
}