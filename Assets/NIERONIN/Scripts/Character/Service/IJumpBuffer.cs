using UnityEngine;

public interface IJumpBufer
{
    float CoyoteTimer { get; }
    float JumpBufferTimer { get; }
    void ResetCoyoteTimer();
    void ResetJumpBufferTimer();
}
