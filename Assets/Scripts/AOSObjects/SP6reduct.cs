using System.Collections;
using AosSdk.Core.Interaction.Interfaces;
using AosSdk.Core.Utils;
using UnityEngine;
using UnityEngine.Events;
[AosObject(name: "СП6 Редуктор")]
public class SP6reduct : AosObjectBase
{
    [SerializeField] private MovebleObject _sp6Reduct;

    [AosAction(name: "Сменить состояние объекта true - исправен, false - неисправен")]
    public void SetCondition(bool value)
    {
        _sp6Reduct.SetCondition(value);
    }

    [AosAction(name: "Проиграть анимацию починки объекта со сменой состояния на исправен")]
    public void RepairReduct()
    {
        _sp6Reduct.RepairObject();
    }

}
