﻿using UnityEngine;
using UnityEngine.Events;

public class IsInRange : MonoBehaviour
{
#pragma warning disable CS0649
    [SerializeField] private float min;
    [SerializeField] private float max;
    [SerializeField] private UnityEventBool result;
    [SerializeField] private UnityEvent isTrue;
    [SerializeField] private UnityEvent isFalse;
#pragma warning restore CS0649

    private void OnValidate()
    {
        if (min > max)
            min = max;
    }

    public void Check(float value)
    {
        var res = value <= max && value >= min;
        result.Invoke(res);
        if (res)
            isTrue.Invoke();
        else
            isFalse.Invoke();
    }
}
