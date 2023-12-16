using System;
using UnityEngine;

public class Player : MonoBehaviour, IDieable
{
    [SerializeField] private GameStats _stats;
    private void Awake()
    {
        ServiceLocator.Player = this;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.TryGetComponent(out Enemy enemy))
            Die();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.TryGetComponent(out Coin coin))
        {
            coin.Destroy();
            _stats.TryAddCoin(1);
        }
    }

    public void Die()
    {
        ServiceLocator.MainUI.ShowLoseScreen();
    }
}