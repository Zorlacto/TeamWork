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
    public TextMeshProUGUI healthtext;



    public float health;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        Time.timeScale = 1;
        health = 10f;

        healthtext.text = "Health: " + health.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        //GameObject.FindObjectOfType<PlayerTwoMovement>().health;

        float t = Time.time - startTime;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");

        timertext.text = minutes + ":" + seconds;

        

        NoHealth();
    }

    public void UpdateHealth()
    {
        health -= 1f;
        healthtext.text = "Health: " + health.ToString();
    }

    public void NoHealth()
    {
        if (health <= 0)
        {
            Time.timeScale = 0;
            timertext.color = Color.yellow;
            gameover.SetActive(true);
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("DeathBox"))
        {
            Time.timeScale = 0;
            timertext.color = Color.yellow;
            gameover.SetActive(true);
        }
    }
}
