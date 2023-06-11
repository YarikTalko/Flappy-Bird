using UnityEngine;

public class GameAssets : MonoBehaviour
{
    private static GameAssets instanse;

    public static GameAssets GetInstance() 
    { 
        return instanse; 
    }

    private void Awake()
    {
        instanse = this;
    }

    public Sprite pipeHeadSprite;
}
