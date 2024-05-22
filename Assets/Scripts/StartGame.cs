using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void startGame()
    {
        //загрузка второй сцены с игрой(SampleScene)
        SceneManager.LoadScene(1);
    }
    public void exitGame()
    {
        //выход из игры
        Application.Quit();
    }
    public void ruleGame()
    {
        SceneManager.LoadScene(3);
    }
}
