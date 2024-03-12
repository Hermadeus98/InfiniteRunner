using UnityEngine;

/// <summary>
/// SINGLETON : Ici on a une seule instance static et accessible de partout dans le code.
/// /!\ Ceci n'est pas un vrai singleton.
/// </summary>
public class UIManager : MonoBehaviour
{
    private static UIManager _instance = null;
    public static UIManager Instance { get => _instance; }

    [Header("References")]
    [SerializeField] private HealthText _healthText = null;

    /// <summary>
    /// Awake() est appelé au lancement d'une scene : avant le Start();
    /// </summary>
    private void Awake()
    {
        if(_instance != null)
        {
            // Un logWarning permet d'afficher une erreur mais pas critique pour le programme.
            Debug.LogWarning("_instance is already existing ?! Maybe multiple UIManager are existing in the scene ?", gameObject);
            // On veut une seule instance car c'est un singleton : on detruit l'instance en trop !
            Destroy(gameObject);
        }

        // this = l'instance appartenant à l'objet (moi).
        _instance = this;
    }

    public void SetHealthText(int currentHealth, int maxHealth)
    {
        // le ? est un check à null (donc vérifier si une valeur est assigné dans la variable !): 
        // cela revient à écrire if(_healthText == null) { return; }
        // Attention avec cette écriture car aucune erreur n'est visible !

        _healthText?.SetHealthText(currentHealth, maxHealth);
    }
}
