using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class a30sec : MonoBehaviour
{
    private float time = 0f;
    public Text text;
    public GameObject gameObject;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time == 30) gameObject.SetActive(true);
    }
}
