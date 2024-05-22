using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Stone")
            Destroy(other.gameObject);//уничтожение камня
        if (other.tag == "Player")
            SceneManager.LoadScene(2);//загрузка сцены Lose
    }
}
