using System;
using UnityEngine;

public class MovementInputProvider : MonoBehaviour, IMovementInputProvider
{
    public float MovementDirection { get; }

    public event Action JumpRequested;

    TODO
}
