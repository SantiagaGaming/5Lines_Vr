using System.Collections;
using AosSdk.Core.Interaction.Interfaces;
using AosSdk.Core.Utils;
using UnityEngine;
using UnityEngine.Events;
[AosObject(name: "��6 �����")]
public class SP6engine : AosObjectBase
{

    [SerializeField] private MovebleObject _sp6Engine;
    [SerializeField] private BaseObject _baseObject;



    [AosAction(name: "������� ��������� ������� true - ��������, false - ����������")]
    public void SetCondition(bool value)
    {
        _sp6Engine.SetCondition(value);
    }

    [AosAction(name: "��������� �������� ������� ������� �� ������ ��������� �� ��������")]
    public void RepairEngine()
    {
        _sp6Engine.RepairObject();
    }

}
