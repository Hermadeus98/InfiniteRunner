using UnityEngine;
using TMPro;

public class HealthText : MonoBehaviour
{
    [Header("References")] // Cette attribut permet d'ajouter un titre dans l'éditeur de Unity !
    [SerializeField] private TextMeshProUGUI _text = null;

    public void SetHealthText(int currentHealth, int maxHealth)
    {
        // le $ permet de formater le string : https://learn.microsoft.com/fr-fr/dotnet/api/system.string.format?view=net-8.0
        string newText = $"{currentHealth} / {maxHealth}";
        _text.SetText(newText);
    }
}
