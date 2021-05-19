using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCounter : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private TMP_Text _coinsText;

    private void OnEnable()
    {
        _player.CoinPicked += OnCoinPicked;
    }

    private void OnDisable()
    {
        _player.CoinPicked -= OnCoinPicked;
    }

    private void Start()
    {
        OnCoinPicked(0);
    }

    private void OnCoinPicked(int coins)
    {
        _coinsText.text = coins.ToString();
    }
}
