using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrelkaContoller : MonoBehaviour
{
    [SerializeField] private StrelkaAOS _strelkaAOS;

    private void OnEnable()
    {
      
    }
    private void OnDisable()
    {
   

    }

    public void OnStrelkaSwitch(bool value)
    {
        _strelkaAOS.TrySwitchStrelka(value);
    }
}
