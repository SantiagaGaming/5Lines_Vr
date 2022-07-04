using System.Collections;
using AosSdk.Core.Interaction.Interfaces;
using AosSdk.Core.Utils;
using UnityEngine;
using UnityEngine.Events;
[AosObject(name: "Муфта ПАД С")]
public class MuftaPadC : AosObjectBase
{
    [SerializeField] private MovebleObject _padObject;
    [SerializeField] private BaseObject _baseObject;


    [AosAction(name: "Сменить состояние объекта true - исправен, false - неисправен")]
    public void SetCondition(bool value)
    {
        _padObject.SetCondition(value);
    }

    [AosAction(name: "Проиграть анимацию починки объекта со сменой состояния на исправен")]
    public void RepairPad()
    {
        _padObject.RepairObject();
    }

}
