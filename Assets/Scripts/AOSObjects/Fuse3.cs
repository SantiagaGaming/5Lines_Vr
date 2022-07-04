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


    [AosAction(name: "Сменить состояние объекта true - исправен, false - неисправен")]
    public void SetCondition(bool value)
    {
        _fuse.SetCondition(value);
    }

    [AosAction(name: "Проиграть анимацию починки объекта со сменой состояния на исправен")]
    public void RepairFuse()
    {
        _fuse.RepairObject();
    }

}