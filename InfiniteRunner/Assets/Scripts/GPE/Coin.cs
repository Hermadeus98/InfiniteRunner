using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private int _points = 0;
    [SerializeField] private ParticleSystem _poofFxPrefab = null;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out CoinTrigger coinTrigger))
        {
            coinTrigger.AddScore(_points);
        }

        PlayPoofFx();
        Destroy(gameObject);
    }

    private void PlayPoofFx()
    {
        ParticleSystem poofFxInstance = Instantiate(_poofFxPrefab);
        poofFxInstance.transform.position = transform.position;
        poofFxInstance.Play();
    }
}
