using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class FloatRange
{
    public float min, max;

    public float RandomValueInRange
    {
        get
        {
            return Random.Range(min, max);
        }
    }

    public FloatRange(float value)
    {
        min = max = value;
    }

    public FloatRange(float min, float max)
    {
        this.min = min;
        this.max = max < min ? min : max;
    }    
}
