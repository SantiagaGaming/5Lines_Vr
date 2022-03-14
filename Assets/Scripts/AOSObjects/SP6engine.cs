using System.Collections;
using AosSdk.Core.Interfaces;
using AosSdk.Core.Utils;
using UnityEngine;
using UnityEngine.Events;
[AosObject(name: "��6 �����")]
public class SP6engine : AosObjectBase
{
    [SerializeField] private MovebleObject _sp6Engine;

    [AosAction(name: "������� ��������� ������� true - ��������, false - ����������")]
    public void SetCondition(bool value)
    {
        _sp6Engine.SetCondition(value);
    }

    [AosAction(name: "��������� �������� ������� ������� �� ������ ��������� �� ��������")]
    public void RepairNmsh()
    {
        _sp6Engine.RepairObject();
    }

}
