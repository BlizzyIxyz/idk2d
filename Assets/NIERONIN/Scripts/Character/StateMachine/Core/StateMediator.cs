using UnityEngine;

public class StateMediator
{
    public readonly IAnimationHandler m_AnimationHandler;
    public readonly IMovementHendler m_MovementHandler;
    public readonly ISoundHandler m_SoundHandler;
    public readonly JumpBufer m_JumpBufer;

    public readonly Rigidbody2D m_Rigidbody;
    public readonly Animator m_Animator;
    public readonly AudioSource m_AudioSource;

    public StateMediator()
    {
        m_AnimationHandler = new AnimationHandler(m_Animator);
        m_MovementHandler = new MovementHandler(m_Rigidbody);
        m_SoundHandler = new SoundHandler(m_AudioSource);
    }
}
