using System.Collections;
using AosSdk.Core.Interaction.Interfaces;
using AosSdk.Core.Utils;
using UnityEngine;
using UnityEngine.Events;
[AosObject(name: "Curve 3")]
public class Curve3 : AosObjectBase
{
    [SerializeField] private MovebleObject _curve;
    [SerializeField] private BaseObject _baseObject;


    [AosAction(name: "??????? ????????? ??????? true - ????????, false - ??????????")]
    public void SetCondition(bool value)
    {
        _curve.SetCondition(value);
    }

    [AosAction(name: "????????? ???????? ??????? ??????? ?? ?????? ????????? ?? ????????")]
    public void RepairCurve()
    {
        _curve.RepairObject();
    }

}