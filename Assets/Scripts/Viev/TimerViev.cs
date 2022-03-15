using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class TimerViev : MonoBehaviour
{
    [SerializeField] private Text _timerText;
    public void ShowTimerText(string time)
    {
        _timerText.text = time;
    }

}
