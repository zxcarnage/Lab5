using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class JetpackBulletMover : MonoBehaviour, IJetpackBulletMover
{
    [SerializeField] private float _velocity;

    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    public void Shoot(Vector3 point)
    {
        _rigidbody.velocity = new Vector2(point.x, point.y * _velocity);
    }
}
