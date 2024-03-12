using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    [SerializeField] private int _damage = 0;

    private void OnTriggerEnter(Collider other)
    {
        InflictDamage(other);
    }

    private void InflictDamage(Collider other)
    {
        DamageTrigger healthTrigger = other.gameObject.GetComponent<DamageTrigger>();

        if (healthTrigger == null)
        {
            Debug.LogError($"{other.gameObject.name} don't contains any {nameof(DamageTrigger)} components.");
            return;
        }

        healthTrigger.MakeDamage(_damage);
    }
}
