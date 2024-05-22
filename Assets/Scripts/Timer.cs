using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float time=0f;
    public Text text;
    public static Text Result;
    void Start()
    {
        text.text = time.ToString();
    }

    void Update()
    {
        time += Time.deltaTime;
        text.text = Mathf.Round(time).ToString();
        Result.text = text.text;
    }
    //public void ShowMessageBox()
    //{
    //    MessageSign.SetActive(true);
    //    MessageText.text = texts[i];
    //    MessageText.enabled = true;
    //    messageShow = true;
    //}

    //void Accept()
    //{
    //    if (messageShow)
    //    {
    //        hideMessageBox();
    //        i++;
    //        if (i < texts.Length)
    //        {
    //            ShowMessageBox();
    //        }
    //        else
    //            Destroy(gameObject);
    //    }
    //}

    //void hideMessageBox()
    //{
    //    MessageSign.SetActive(false);
    //    MessageText.enabled = false;
    //    messageShow = false;
    //}
}
