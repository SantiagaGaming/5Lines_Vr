using System.Collections;
using AosSdk.Core.Interaction.Interfaces;
using AosSdk.Core.Utils;
using UnityEngine;
using UnityEngine.Events;
[AosObject(name: "��6 ��������")]
public class SP6reduct : AosObjectBase
{
    [SerializeField] private MovebleObject _sp6Reduct;

    [AosAction(name: "������� ��������� ������� true - ��������, false - ����������")]
    public void SetCondition(bool value)
    {
        _sp6Reduct.SetCondition(value);
    }

    [AosAction(name: "��������� �������� ������� ������� �� ������ ��������� �� ��������")]
    public void RepairReduct()
    {
        _sp6Reduct.RepairObject();
    }

}
