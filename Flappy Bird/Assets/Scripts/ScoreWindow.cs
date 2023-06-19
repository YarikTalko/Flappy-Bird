using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreWindow : MonoBehaviour
{
    [SerializeField] private GameObject highscoreTextObj;
    [SerializeField] private GameObject scoreTextObj;
    private TMP_Text highscoreText;
    private TMP_Text scoreText;

    private void Awake()
    {
        scoreText = scoreTextObj.GetComponent<TMP_Text>();
        highscoreText = highscoreTextObj.GetComponent<TMP_Text>();
    }

    private void Start()
    {
        highscoreText.text = "HIGHSCORE: " + Score.GetHighscore().ToString();
    }

    private void Update()
    {
        scoreText.text = Level.GetInstance().GetPipesPassedCount().ToString();
    }
}
