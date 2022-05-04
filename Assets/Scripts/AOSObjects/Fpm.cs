using System.Collections;
using AosSdk.Core.Interaction.Interfaces;
using AosSdk.Core.Utils;
using UnityEngine;
using UnityEngine.Events;
[AosObject(name: "���")]
public class Fpm : AosObjectBase
{
    [SerializeField] private MovebleObject _fpm;

    [AosAction(name: "������� ��������� ������� true - ��������, false - ����������")]
    public void SetCondition(bool value)
    {
        _fpm.SetCondition(value);
    }

    [AosAction(name: "��������� �������� ������� ������� �� ������ ��������� �� ��������")]
    public void RepairFpm()
    {
        _fpm.RepairObject();
    }

}
