using UnityEngine;

public class Controller : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Character _character = null;

    [Header("Bindings")]
    [SerializeField] private KeyCode _leftKey = KeyCode.Q;
    [SerializeField] private KeyCode _rightKey = KeyCode.D;

    // Update s'exectute à chaque frame
    private void Update()
    {
        // Input.GetKeyDown(binding) permet de tester si on appuie sur une touche.
        if (Input.GetKeyDown(_leftKey))
        {
            _character.MoveLeft();
        }

        if (Input.GetKeyDown(_rightKey))
        {
            _character.MoveRight();
        }
    }
}
