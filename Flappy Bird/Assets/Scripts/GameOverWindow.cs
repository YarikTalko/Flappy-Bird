using CodeMonkey.Utils;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameOverWindow : MonoBehaviour
{
    [SerializeField] private GameObject scoreTextObject;
    [SerializeField] private GameObject retryBtnObject;
    private TMP_Text scoreText;

    private void Awake()
    {
        scoreText = scoreTextObject.GetComponent<TMP_Text>();

        retryBtnObject.GetComponent<Button_UI>().ClickFunc = () =>
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("GameScene");
        };
    }

    private void Start()
    {
        Bird.GetInstance().OnDied += Bird_OnDied;
        Hide();
    }

    private void Bird_OnDied(object sender, System.EventArgs e)
    {
        scoreText.text = Level.GetInstance().GetPipesPassedCount().ToString();
        Show();
    }

    private void Hide()
    {
        gameObject.SetActive(false);
    }

    private void Show()
    {
        gameObject.SetActive(true);
    }
}
