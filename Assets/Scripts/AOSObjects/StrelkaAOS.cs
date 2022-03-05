using System.Collections;
using AosSdk.Core.Interfaces;
using AosSdk.Core.Utils;
using UnityEngine;
using UnityEngine.Events;

[AosObject(name: "Стрелка")]

public class StrelkaAOS : AosObjectBase
    
{
    [SerializeField] private StrelkaContoller _strelka;

    [AosEvent(name: "Игрок переводит стрелку в плюс")]
    public event AosEventHandlerWithAttribute OnStrelkaMeasurePlus;
    [AosEvent(name: "Игрок переводит стрелку в минус")]
    public event AosEventHandlerWithAttribute OnStrelkaMeasureMinus;

    [AosAction(name: "Задать состояние точки true +, false -")]
    public void SetStrelkaPosition()
    {

    }
}
