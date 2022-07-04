using System.Collections;
using AosSdk.Core.Interaction.Interfaces;
using AosSdk.Core.Utils;
using UnityEngine;
using UnityEngine.Events;
[AosObject(name: "����� ��� �")]
public class MuftaPadC : AosObjectBase
{
    [SerializeField] private MovebleObject _padObject;
    [SerializeField] private BaseObject _baseObject;


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
