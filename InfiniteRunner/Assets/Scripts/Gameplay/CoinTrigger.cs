using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinTrigger : MonoBehaviour
{
    [SerializeField] private Score _score = null;

    public void AddScore(int score)
    {
        if(_score == null)
        {
            Debug.LogError("_score should not be null.", gameObject);
            return;
        }

        _score.AddScore(score);
    }
}
