using System;
using UnityEngine;

public class InGameUI : MonoBehaviour
{
    [SerializeField] private CoinAmount _coinAmount;
    [SerializeField] private GameStats _stats;

    private void OnEnable()
    {
        _stats.CoinsIncreased += OnCoinsIncreased;
    }

    private void OnDisable()
    {
        _stats.CoinsIncreased -= OnCoinsIncreased;
    }

    private void OnCoinsIncreased(int currentCoins)
    {
        _coinAmount.UpdateCoinAmount(currentCoins);
    }
}
