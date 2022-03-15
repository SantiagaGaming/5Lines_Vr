using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Strelka : MonoBehaviour
{
    private bool _condition;
    public void SetCondition(bool value)
    {
        _condition = value;
    }
    public bool GetCondition()
    {
        return _condition;
    }

}

