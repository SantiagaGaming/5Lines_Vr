using System.Collections;
using AosSdk.Core.Interfaces;
using AosSdk.Core.Utils;
using UnityEngine;
using UnityEngine.Events;
[AosObject(name: "����� ��� �")]
public class MuftaPadA : AosObjectBase
{
    [SerializeField] private MovebleObject _padObject;

    [AosAction(name: "������� ��������� ������� true - ��������, false - ����������")]
    public void SetCondition(bool value)
    {
        _padObject.SetCondition(value);
    }

    [AosAction(name: "��������� �������� ������� ������� �� ������ ��������� �� ��������")]
    public void RepairPad()
    {
        _padObject.RepairObject();
    }

}
