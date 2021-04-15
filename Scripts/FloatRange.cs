﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct FloatRange
{
    [SerializeField]
    [Tooltip("Minimum value of the float")]
    private float _min;
    [SerializeField]
    [Tooltip("Maximum value of the float")]
    private float _max;

    public float min => _min;
    public float max => _max;
    public float length => _max - _min;
}