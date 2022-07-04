using System.Collections;
using AosSdk.Core.Interaction.Interfaces;
using AosSdk.Core.Utils;
using UnityEngine;
using UnityEngine.Events;
[AosObject(name: "ЦП 18 Блок СП")]
public class Cp18 : AosObjectBase
{
    [SerializeField] private MovebleObject _cp;
    [SerializeField] private BaseObject _baseObject;


    [AosAction(name: "Сменить состояние объекта true - исправен, false - неисправен")]
    public void SetCondition(bool value)
    {
        _cp.SetCondition(value);
    }

    [AosAction(name: "Проиграть анимацию починки объекта со сменой состояния на исправен")]
    public void RepairCp()
    {
        _cp.RepairObject();
    }

}
