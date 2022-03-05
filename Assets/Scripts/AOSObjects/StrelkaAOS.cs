using System.Collections;
using AosSdk.Core.Interfaces;
using AosSdk.Core.Utils;
using UnityEngine;
using UnityEngine.Events;

[AosObject(name: "�������")]

public class StrelkaAOS : AosObjectBase
    
{
    [SerializeField] private StrelkaContoller _strelka;

    [AosEvent(name: "����� ��������� ������� � ����")]
    public event AosEventHandlerWithAttribute OnStrelkaMeasurePlus;
    [AosEvent(name: "����� ��������� ������� � �����")]
    public event AosEventHandlerWithAttribute OnStrelkaMeasureMinus;

    [AosAction(name: "������ ��������� ����� true +, false -")]
    public void SetStrelkaPosition()
    {

    }
}
