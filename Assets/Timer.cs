using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{

    public Text timertext;
    private float startTime;
    public GameObject gameover;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float t = Time.time - startTime;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");

        timertext.text = minutes + ":" + seconds;

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Death"))
        {
            Time.timeScale = 0;
            timertext.color = Color.yellow;
            gameover.SetActive(true);
        }
    }
}
