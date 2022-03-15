using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerController : MonoBehaviour
{
    [SerializeField] private TimerViev _viev;
    [SerializeField] private Timer _timer;

    private void Update()
    {
        _viev.ShowTimerText(_timer.ReturnTime());
    }

    public void ControlTimer(bool value)
    {
        _timer.ControlTime(value);
    }

}

