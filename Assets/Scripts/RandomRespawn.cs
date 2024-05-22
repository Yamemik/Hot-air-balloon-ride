using UnityEngine;

public class RandomRespawn : MonoBehaviour
{
    [SerializeField]
    private GameObject obj;
    float RandX;
    Vector2 whereToSpawn;
    [SerializeField]
    private float spawnRate = 2f;
    float nextSpawn = 0.0f;
    void Update()
    {
        if (Time.time > nextSpawn){
            nextSpawn = Time.time + spawnRate;
            RandX = Random.Range(-15f, 15f);
            whereToSpawn = new Vector2(RandX, transform.position.y);
            Instantiate(obj, whereToSpawn, Quaternion.identity);
        }
    }
}
