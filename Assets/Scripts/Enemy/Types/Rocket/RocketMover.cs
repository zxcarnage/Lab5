using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class RocketMover : MonoBehaviour, IRocketMover
{
    [SerializeField] private float _velocity;

    private Rigidbody2D _rigidbody2D;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    public void Move()
    {
        _rigidbody2D.velocity = Vector2.left * _velocity;
    }
}
