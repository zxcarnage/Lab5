using System;
using UnityEngine;

[RequireComponent(typeof(IRocketMover))]
public class Rocket : Enemy
{
    private IRocketMover _mover;

    private void Awake()
    {
        _mover = GetComponent<IRocketMover>();
    }

    private void OnEnable()
    {
        _mover.Move();
    }
}