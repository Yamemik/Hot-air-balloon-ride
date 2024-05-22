using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame0 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
            SceneManager.LoadScene(2);
    }
}
