using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeedbackManager : MonoBehaviour
{
    private static FeedbackManager _instance = null;
    public static FeedbackManager Instance => _instance;


    [SerializeField] private ScreenShake _screenShake = null;

    private void Awake()
    {
        _instance = this;
    }

    public void PlayScreenShake(float duration)
    {
        _screenShake.PlayScreenShake(duration);
    }
}
