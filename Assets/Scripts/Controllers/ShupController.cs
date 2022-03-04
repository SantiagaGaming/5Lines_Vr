using System.Collections;
using AosSdk.Core.Interfaces;
using AosSdk.Core.Utils;
using UnityEngine;
using UnityEngine.Events;

[AosObject(name: "���")]
public class ShupController : AosObjectBase
{
    public UnityAction<string> SetMeasureTextEvent;

    [SerializeField] private GameObject _redShup;
    [SerializeField] private GameObject _blackShup;

    [AosEvent(name: "��������� ����� �������")]
    public event AosEventHandlerWithAttribute OnShupConnected;

    private bool _firstMeasure = false;
    public string measureText;

    [AosAction(name: "��������� �����")]
    public string SetShupPosition([AosParameter("������� ���� � �������� ����� ���������")]Transform newPos, string text)
    {
      
        if (!_firstMeasure)
        {
            if (_redShup.transform.position != newPos.position && _blackShup.transform.position != newPos.position)
            {
                _redShup.transform.position = newPos.position;
                _blackShup.transform.position = Vector3.zero;
                _firstMeasure = true;
                measureText = text;
                SetMeasureTextEvent?.Invoke(measureText);
                OnShupConnected?.Invoke(measureText);
            }
        }
        else if (_firstMeasure)
        {
            if (_redShup.transform.position != newPos.position && _blackShup.transform.position != newPos.position)
            {
                _blackShup.transform.position = newPos.position;
                _firstMeasure = false;
                measureText += " " + text;
                SetMeasureTextEvent?.Invoke(measureText);
                OnShupConnected?.Invoke(measureText);
            }
        }
        return measureText;
    }

  public void ResetShupPosition()
    {
        _redShup.transform.position = Vector3.zero;
        _blackShup.transform.position = Vector3.zero;
        measureText = "";
        SetMeasureTextEvent?.Invoke("");
        _firstMeasure = false;
    }
}
