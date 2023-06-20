using System;
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
    public Transform pfPipeHead;
    public Transform pfPipeBody;
    public Transform pfGround;
    public Transform pfCloud_1;
    public Transform pfCloud_2;
    public Transform pfCloud_3;

    public SoundAudioClip[] soundAudioClipArray;

    [Serializable] public class SoundAudioClip
    {
        public SoundManager.Sound sound;
        public AudioClip audioClip;
    }
}
