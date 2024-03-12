using UnityEngine;

public class DamageTrigger : MonoBehaviour
{
    [SerializeField] private Health _health = null;

    public void MakeDamage(int damageReceived)
    {
        if(_health == null)
        {
            Debug.LogError($"{nameof(_health)} has no reference.");
            return;
        }

        _health.MakeDamage(damageReceived);
    }
}
