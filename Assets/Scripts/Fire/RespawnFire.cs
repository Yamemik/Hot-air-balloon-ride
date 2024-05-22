using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnFire : MonoBehaviour
{
    [SerializeField]
    private GameObject obj;
    float RandX;
    float RandY;
    Vector2 whereToSpawn;
    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Fire").Length == 0){
            RandX = Random.Range(-7.37f, 7.57f);
            RandY = Random.Range(-8f, 8f);
            whereToSpawn = new Vector2(RandX, RandY);
            Instantiate(obj, whereToSpawn, Quaternion.identity);
        }
    }
}
