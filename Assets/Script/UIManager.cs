using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public float tiempo = 0.0f;
    int score = 0;
    [SerializeField] TextMeshProUGUI scoreText;
   // [SerializeField] TextMeshProUGUI timerText;

    //Nuevo Metodo

    public void AddScore(int punto)
    {
        score = score + (punto);
        /*if (score >= 500)
        {
            SceneManager.LoadScene(3);
        }
        else if (score <= -1)
        {
            SceneManager.LoadScene(2);

        }*/
        scoreText.text = score.ToString();

    }/*
    public void AddTimer(int punto)
    {
        tiempo += punto;
        timerText.text = tiempo.ToString();
    }
      int score = 0;

      [SerializeField] TextMeshProUGUI scoreText;

      public void AddScore()
      {
          score++;

          scoreText.text = score.ToString();
      }*/

    //Timer
    public void Update()
    {
        tiempo += Time.deltaTime;
        timerText.text = "" + tiempo.ToString("f0");

    }
}

