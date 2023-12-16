using System;
using UnityEngine;


[CreateAssetMenu(fileName = "New game stats", menuName = "Stats/Game stats", order = 0)]
public class GameStats : ScriptableObject
{
    [SerializeField] private int _coins;

    public event Action<int> CoinsIncreased;

    public void TryAddCoin(int amount)
    {
        if (amount >= 1)
            AddCoin(amount);
    }

    private void AddCoin(int amount)
    {
        _coins += amount;
        CoinsIncreased?.Invoke(_coins);
    }
}