using UnityEngine;

public class JumpBufer : IJumpBufer
{
    private readonly MovementConfig _movementConfig;

    public float CoyoteTimer {  get; private set; }
    public float JumpBufferTimer { get; private set; }

    public JumpBufer(MovementConfig movementConfig)
    {
        _movementConfig = movementConfig;
    }

    public void UpdateTimers()
    {
        if (CoyoteTimer >= 0)
            CoyoteTimer -= Time.deltaTime;
        if (JumpBufferTimer >= 0)
            JumpBufferTimer -= Time.deltaTime;
    }

    public void ResetCoyoteTimer() => CoyoteTimer = _movementConfig.JumpCoyoteTime;
    public void ResetJumpBufferTimer() => CoyoteTimer = _movementConfig.JumpBufferTime;
}
