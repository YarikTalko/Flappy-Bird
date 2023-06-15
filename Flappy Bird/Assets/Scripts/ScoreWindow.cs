using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreWindow : MonoBehaviour
{
    [SerializeField] private GameObject scoreTextObject;
    private TMP_Text scoreText;

    private void Awake()
    {
        scoreText = scoreTextObject.GetComponent<TMP_Text>();
    }

    private void Update()
    {
        scoreText.text = Level.GetInstance().GetPipesPassedCount().ToString();
    }
}
