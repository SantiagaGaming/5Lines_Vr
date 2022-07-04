using System.Collections;
using AosSdk.Core.Interaction.Interfaces;
using AosSdk.Core.Utils;
using UnityEngine;
using UnityEngine.Events;
[AosObject(name: "�� 18 ���� ��")]
public class Cp18 : AosObjectBase
{
    [SerializeField] private MovebleObject _cp;
    [SerializeField] private BaseObject _baseObject;


    [AosAction(name: "������� ��������� ������� true - ��������, false - ����������")]
    public void SetCondition(bool value)
    {
        _cp.SetCondition(value);
    }

    [AosAction(name: "��������� �������� ������� ������� �� ������ ��������� �� ��������")]
    public void RepairCp()
    {
        _cp.RepairObject();
    }

}
