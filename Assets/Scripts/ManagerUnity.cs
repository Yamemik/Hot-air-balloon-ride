using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerUnity : MonoBehaviour
{
    public Text Result;
    // Start is called before the first frame update
    void Start()
    {
        Result.text = Timer.Result.text;
    }

    // Update is called once per frame
    void Update()
    {
    }
}
