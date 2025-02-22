using System;
using UnityEngine;

public interface IGroundedComponent
{
    public bool IsGrounded { get; }
    event Action<bool> GroundedStateChange;
}
