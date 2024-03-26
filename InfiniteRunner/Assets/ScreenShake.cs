using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using System.Threading.Tasks;
using System;

public class ScreenShake : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera _camera = null;

    private CinemachineBasicMultiChannelPerlin _perlin = null;

    private void Start()
    {
        _perlin = _camera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
    }

    // Async permet d'avoir des fonctions timées.
    public async void PlayScreenShake(float shakeDuration)
    {
        _perlin.m_AmplitudeGain = 1.0f;
        _perlin.m_FrequencyGain = 1.0f;

        await Task.Delay(TimeSpan.FromSeconds(shakeDuration));

        StopCameraShake();
    }

    private void StopCameraShake()
    {
        _perlin.m_AmplitudeGain = 0.0f;
        _perlin.m_FrequencyGain = 0.0f;
    }
}
