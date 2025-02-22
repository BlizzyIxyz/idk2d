using UnityEngine;

public interface IAnimationHandler
{
    void SetBool (string key, bool value);
    void SetFloat (string key, float value);
    void SetTrigger(string key);
}
