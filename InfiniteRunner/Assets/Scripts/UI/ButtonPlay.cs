using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;

public class ButtonPlay : MonoBehaviour
{
    [SerializeField] private string _sceneToLoad = "LevelOne";

    [Preserve]
    public void LaunchLevelOne()
    {
        SceneManager.LoadScene(_sceneToLoad);
    }
}
