using System;
using UnityEngine;

[RequireComponent(typeof(PlayerInput))]
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _verticalPushPower;
    [SerializeField] private float _horizontalMovingSpeed;
    
    private IPlayerInput _playerInput;
    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _playerInput = GetComponent<PlayerInput>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        _rigidbody.gravityScale = 1;
    }

    private void Update()
    {
        TryMoveVertical();
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        MoveHorizontaly();
        
    }

    private void MoveHorizontaly()
    {
        var rightMovementVector = Vector3.right * _horizontalMovingSpeed * Time.fixedDeltaTime;
        transform.position += rightMovementVector;
    }

    private void TryMoveVertical()
    {
        if (_playerInput.HandleInput())
            MoveVertical();
    }

    private void MoveVertical()
    {
        _rigidbody.velocity = Vector2.up * _verticalPushPower * Time.fixedDeltaTime;
    }
}
