using UnityEngine;
using TMPro;

public class PointText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text = null;

    public void SetPointText(int points)
    {
        string pointText = $"Points = {points}";
        _text.SetText(pointText);
    }
}
