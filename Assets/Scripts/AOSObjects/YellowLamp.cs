using System.Collections;
using AosSdk.Core.Interaction.Interfaces;
using AosSdk.Core.Utils;
using UnityEngine;
using UnityEngine.Events;


[AosObject(name: "������ ��������")]
public class YellowLamp : AosObjectBase
{
    [SerializeField] private Lamp _lamp;


    [AosAction(name: "������� ���� ��������: ������")]
    public void SetLampColor()
    {
        _lamp.ChangeColor();
    }

    [AosAction(name: "������� ���� ��������: ������")]
    public void ResetoLampColor()
    {
        _lamp.ResetColor();
    }
}
