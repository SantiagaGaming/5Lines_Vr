using System.Collections;
using AosSdk.Core.Interfaces;
using AosSdk.Core.Utils;
using UnityEngine;
using UnityEngine.Events;
[AosObject(name: "����� ������")]
public class StoneLeft : AosObjectBase
{
    [SerializeField] private Stone _stone;

    [AosAction(name: "������� ��������� ������� true - �������, false - ���������")]
    public void SetCondition(bool value)
    {
        _stone.EnableStone(value);
    }

}
