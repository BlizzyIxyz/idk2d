using System;

public interface IMovementInputProvider
{
    public float MovementDirection { get; }
    public event Action JumpRequested;
}
