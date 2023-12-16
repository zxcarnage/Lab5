using System;
using UnityEngine;

public class PlayerInput : MonoBehaviour, IPlayerInput
{
    public bool HandleInput()
    {
        return Input.GetMouseButton(0);
    }
}