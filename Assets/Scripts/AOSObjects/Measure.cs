using System.Collections;
using AosSdk.Core.Interfaces;
using AosSdk.Core.Utils;
using UnityEngine;
using UnityEngine.Events;

[AosObject(name: "����� ���������")]
public class Measure : AosObjectBase
{
    [SerializeField] private PlayerCanvasController _playerCanvasController;
    [AosAction(name: "������ ����� ���������")]
    public void SetMeasureText(string text)
    {
        //_playerCanvasController.SetMeasureText(text);
    }
    [AosAction("�������� ��������� ���� ���������")]
    public void EnablaMeasureIcon([AosParameter("�����������")] bool value)
    {
      //  _playerCanvasController.MeasureIconEnabler(value);
    }

}
