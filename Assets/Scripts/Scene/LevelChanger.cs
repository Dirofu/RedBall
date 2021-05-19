using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    private int _currentLevel;

    private void Start()
    {
        _currentLevel = SceneManager.GetActiveScene().buildIndex;
    }

    public void Load(int index)
    {
        SceneManager.LoadScene(index);
    }

    public void Restart()
    {
        SceneManager.LoadScene(_currentLevel);
    }
}
