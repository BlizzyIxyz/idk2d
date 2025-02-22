using UnityEngine;

public interface IStateFactory
{
    IState GetState<T>() where T : IState;
}
