using System;
using UnityEngine;

public class GroundedComponent : IGroundedComponent
{
    public bool IsGrounded { get; private set; }
    public event Action<bool> GroundedStateChange;
}
