using System.Collections.Generic;
using UnityEngine;

public class StateFactory : IStateFactory
{
    private Dictionary<System.Type, IState> _cachedStates = new();

    public StateFactory() 
    { 
        InitializeCachedStates();
    }
    private void InitializeCachedStates()
    {
        _cachedStates.Add()
    }
    private IState CreateState<T>() where T : IState
    {
        IState returnableState;

        return returnableState;
    }
    public IState GetState<T>() where T : IState
    {
        if (_cachedStates.TryGetValue(typeof(T), out var state))
            return state;
        else
        {
            Debug.LogWarning($"Cached state {typeof(T)} doesn't exist, {this}");
            return CreateState<T>();
        }
    }
}
