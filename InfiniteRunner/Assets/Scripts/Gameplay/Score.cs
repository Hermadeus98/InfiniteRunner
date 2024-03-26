using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private int _initialScore = 0;

    private int _score = 0;

    private void Start()
    {
        _score = _initialScore;
        UIManager.Instance.SetPointText(_score);
    }

    public void AddScore(int point)
    {
        _score += point;
        UIManager.Instance.SetPointText(_score);
    }
}
