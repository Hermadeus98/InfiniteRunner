using UnityEngine;

public class Health : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private int _maxHealth = 0;

    private int _currentHealth = 0;

    private void Start()
    {
        _currentHealth = _maxHealth;
        SetHealthText();
    }

    public void MakeDamage(int damageReceived)
    {
        _currentHealth -= damageReceived; // -= revient à écrire _currentHealth = _currentHealth - damageReceived;
        _currentHealth = Mathf.Clamp(_currentHealth, 0, _maxHealth); // On borne la valeur d'entrée entre deux valeurs.
        SetHealthText();

        if (_currentHealth == 0)
        {
            Die();
        }
    }

    private void Die()
    {
        UIManager.Instance.ShowLoseView();
        Destroy(gameObject);
    }

    private void SetHealthText()
    {
        if(UIManager.Instance == null)
        {
            Debug.LogError("UIManager.Instance est null !", gameObject);
            return;
        }

        UIManager.Instance?.SetHealthText(_currentHealth, _maxHealth);
    }
}
