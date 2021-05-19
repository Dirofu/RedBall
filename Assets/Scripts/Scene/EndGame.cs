using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    [SerializeField] private GameObject _screen;
    [SerializeField] private Player _player;

    private void OnEnable()
    {
        _player.Dead += ShowScreen;
    }

    private void OnDisable()
    {
        _player.Dead -= ShowScreen;
    }

    private void Start()
    {
        HideScreen();
    }

    public void ShowScreen()
    {
        Time.timeScale = 0;
        _screen.SetActive(true);
    }

    public void HideScreen()
    {
        _screen.SetActive(false);
        Time.timeScale = 1;
    }

    public void GameExit()
    {
        Application.Quit();
    }
}
