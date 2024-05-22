using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed = 15f;//скорость
    private Rigidbody2D rb;
    float dirX;
    float time;
    void Start() 
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnTriggerEnter2D(Collider2D other)//ускорение шара
    {
        if (other.tag == "Fire")
        {
            speed = 25f;
            time = 5f;
            Destroy(other.gameObject);// уничтожение огня
        }
    }
    void Update()
    {
        time -= Time.deltaTime;
        if (time <= 0.0f)
            speed = 10f;
        //движение влево-вправо
        float moveX = Input.GetAxis("Horizontal");
        rb.MovePosition(rb.position + Vector2.right * moveX * speed * Time.deltaTime);
        //движение вверх
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * 8000);
        }
    }
}
