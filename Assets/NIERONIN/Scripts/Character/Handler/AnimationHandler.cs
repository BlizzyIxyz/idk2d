using UnityEngine;

public class AnimationHandler : IAnimationHandler
{
    private Animator _animator;
    public AnimationHandler(Animator animator)
    {
        _animator = animator;
    }
    public void SetBool(string key, bool value)
    {
        _animator.SetBool(key, value);
    }
    public void SetFloat(string key, float value)
    {
        _animator.SetFloat(key, value);
    }
    public void SetTrigger(string key)
    {
        _animator.SetTrigger(key);
    }
}
