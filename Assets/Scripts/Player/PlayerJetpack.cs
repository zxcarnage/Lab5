using System;
using System.Collections;
using UnityEngine;

[RequireComponent(typeof(IPlayerInput))]
public class PlayerJetpack : MonoBehaviour
{
    [SerializeField] [Range(0,0.3f)] private float _bulletsDelay;
    
    private IPlayerInput _playerInput;

    private float _elapsedTime = 0f;
    
    private void Awake()
    {
        _playerInput = GetComponent<IPlayerInput>();
    }

    private void Update()
    {
        TryShoot();
    }

    private void TryShoot()
    {
        if (_playerInput.HandleInput())
            Shoot();

    }

    private void Shoot()
    {
        _elapsedTime += Time.deltaTime;
        if (_elapsedTime >= _bulletsDelay)
        {
            ServiceLocator.BulletSpawner.Spawn();
            _elapsedTime = 0f;
        }
    }
}