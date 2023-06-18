using CodeMonkey.Utils;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameOverWindow : MonoBehaviour
{
    [SerializeField] private GameObject scoreTextObj;
    [SerializeField] private GameObject retryBtnObj;
    [SerializeField] private GameObject mainMenuBtnObj;
    private TMP_Text scoreText;

    private void Awake()
    {
        scoreText = scoreTextObj.GetComponent<TMP_Text>();

        retryBtnObj.GetComponent<Button_UI>().ClickFunc = () =>
        {
            Loader.Load(Loader.Scene.GameScene);
        };
        retryBtnObj.GetComponent<Button_UI>().AddButtonSounds();

        mainMenuBtnObj.GetComponent<Button_UI>().ClickFunc = () =>
        {
            Loader.Load(Loader.Scene.MainMenu);
        };
        mainMenuBtnObj.GetComponent<Button_UI>().AddButtonSounds();
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
