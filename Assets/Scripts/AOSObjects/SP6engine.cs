using System.Collections;
using AosSdk.Core.Interfaces;
using AosSdk.Core.Utils;
using UnityEngine;
using UnityEngine.Events;
[AosObject(name: "СП6 Мотор")]
public class SP6engine : AosObjectBase
{
    [SerializeField] private MovebleObject _sp6Engine;

    [AosAction(name: "Сменить состояние объекта true - исправен, false - неисправен")]
    public void SetCondition(bool value)
    {
        _sp6Engine.SetCondition(value);
    }

    [AosAction(name: "Проиграть анимацию починки объекта со сменой состояния на исправен")]
    public void RepairNmsh()
    {
        _sp6Engine.RepairObject();
    }

}
