using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCreator : MonoBehaviour
{
    [SerializeField] private List<GameObject> _patterns = null;
    [SerializeField] private float _patternSize = 20;
    [SerializeField] private int _patternCount = 100;

    private void Awake()
    {
        InstantiatesAllPatterns();
    }

    private void InstantiatesAllPatterns()
    {
        for (int i = 0; i < _patternCount; i++)
        {
            Vector3 position = new Vector3(0f, 0f, i * _patternSize);
            InstantiateNewPattern(position);
        }
    }

    private void InstantiateNewPattern(Vector3 position)
    {
        int random = Random.Range(0, _patterns.Count);
        GameObject pattern = _patterns[random];

        Instantiate(pattern, position, Quaternion.identity);
    }
}
