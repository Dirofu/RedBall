using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCounter : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private TMP_Text _coinsText;

    private int _coinsCount;

    private void OnEnable()
    {
        _player.CoinPicked += OnValueChanged;
    }

    private void OnDisable()
    {
        _player.CoinPicked -= OnValueChanged;
    }

    private void Start()
    {
        _coinsText.text = _coinsCount.ToString();
    }

    private void OnValueChanged()
    {
        _coinsCount++;
        _coinsText.text = _coinsCount.ToString();
    }
}
