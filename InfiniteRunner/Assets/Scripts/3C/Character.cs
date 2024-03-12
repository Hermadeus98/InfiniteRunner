using UnityEngine;

public class Character : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Transform _transform = null;

    [Header("Balancing")]
    [SerializeField] private float _speed = 0.0f;
    [SerializeField] private float _lateralMovement = 0.0f;
    [SerializeField] private float _maxRightPosition = 0.0f;
    [SerializeField] private float _maxLeftPosition = 0.0f;

    private float _currentPositionX = 0.0f;

    private void Update()
    {
        MoveForward();
    }

    private void MoveForward()
    {
        /* Checker si transform == null permet de v�rifier
         * si la variable _transform � une valeur (une r�f�rence) qui lui est assign�e.
         * Ici, si on veut acc�der � des fonctions ou des valeurs dans _transform, et que celui-ci est nul,
         * alors le programme crasherai, et unity afficherait une erreur dans la console.
         * J'ajoute gameObject en parametre de context afin de retrouver l'objet qui pose probl�me plus facilement.
         * */
        if (_transform == null)
        {
            Debug.LogError($"Missing the reference of _transform in {gameObject.name}.", gameObject);
            return; // Le "return" signifie : J'arr�te l'execution de mon code si la condition est remplie.
        }

        // On cr�� une nouvelle variable dans laquelle on r�cup�re notre position actuelle.
        Vector3 currentPosition = transform.position;

        // On calcule notre prochaine position : 
        // Time.deltaTime correspond � l'intervale en seconde entre cette frame et la frame pr�c�dente.
        Vector3 nextPosition = currentPosition;
        nextPosition.z = currentPosition.z + _speed * Time.deltaTime;

        // On change la position de notre objet.
        _transform.position = nextPosition;
    }

    public void MoveRight()
    {
        if(_currentPositionX >= _maxRightPosition) // Si _currentPositionX est sup�rieure ou �gale � _maxRightPosition.
        {
            return; // Le "return" signifie : J'arr�te l'execution de mon code si la condition est remplie.
        }

        _currentPositionX += _lateralMovement;

        ApplyXPosition();
    }

    public void MoveLeft()
    {
        if (_currentPositionX <= _maxLeftPosition)
        {
            return;
        }

        _currentPositionX -= _lateralMovement;

        ApplyXPosition();
    }

    private void ApplyXPosition()
    {
        Vector3 newPosition = new Vector3();
        newPosition.x = _currentPositionX;
        newPosition.y = _transform.position.y;
        newPosition.z = _transform.position.z;

        _transform.position = newPosition;
    }
}
