using System.Collections;
using AosSdk.Core.Interaction.Interfaces;
using AosSdk.Core.Utils;
using UnityEngine;
using UnityEngine.Events;
[AosObject(name: "Curve 5")]
public class Curve5 : AosObjectBase
{
    [SerializeField] private MovebleObject _curve;
    [SerializeField] private BaseObject _baseObject;


    [AosAction(name: "Сменить состояние объекта true - исправен, false - неисправен")]
    public void SetCondition(bool value)
    {
        _curve.SetCondition(value);
    }

    [AosAction(name: "Проиграть анимацию починки объекта со сменой состояния на исправен")]
    public void RepairCurve()
    {
        _curve.RepairObject();
    }

}