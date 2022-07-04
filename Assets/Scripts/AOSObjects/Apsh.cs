using System.Collections; 
using AosSdk.Core.Interaction.Interfaces;
using AosSdk.Core.Utils;
using UnityEngine;
using UnityEngine.Events;
[AosObject(name: "����")]
public class Apsh : AosObjectBase
{

    [SerializeField] private MovebleObject _nmsh;
    [SerializeField] private BaseObject _baseObject;


    [AosAction(name: "������� ��������� ������� true - ��������, false - ����������")]
    public void SetCondition(bool value)
    {
        _nmsh.SetCondition(value);
    }

    [AosAction(name: "��������� �������� ������� ������� �� ������ ��������� �� ��������")]
    public void RepairNmsh()
    {
        _nmsh.RepairObject();
    }

}
