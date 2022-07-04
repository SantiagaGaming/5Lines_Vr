using System.Collections;
using AosSdk.Core.Interaction.Interfaces;
using AosSdk.Core.Utils;
using UnityEngine;
using UnityEngine.Events;
[AosObject(name: "Fuse 3")]
public class Fuse3 : AosObjectBase
{
    [SerializeField] private MovebleObject _fuse;
    [SerializeField] private BaseObject _baseObject;


    [AosAction(name: "������� ��������� ������� true - ��������, false - ����������")]
    public void SetCondition(bool value)
    {
        _fuse.SetCondition(value);
    }

    [AosAction(name: "��������� �������� ������� ������� �� ������ ��������� �� ��������")]
    public void RepairFuse()
    {
        _fuse.RepairObject();
    }

}