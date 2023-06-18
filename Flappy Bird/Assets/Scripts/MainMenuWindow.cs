using CodeMonkey.Utils;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuWindow : MonoBehaviour
{
    [SerializeField] private GameObject playBtnObj;
    [SerializeField] private GameObject quitBtnObj;
    private void Awake()
    {
        playBtnObj.GetComponent<Button_UI>().ClickFunc = () => 
        {
            Loader.Load(Loader.Scene.GameScene);
        };
        
        quitBtnObj.GetComponent<Button_UI>().ClickFunc= () => 
        { 
            Application.Quit();
        };
    }
}
