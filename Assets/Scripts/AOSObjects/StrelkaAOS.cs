using System.Collections;
using AosSdk.Core.Interaction.Interfaces;
using AosSdk.Core.Utils;
using UnityEngine;
using UnityEngine.Events;

[AosObject(name: "Стрелка")]

public class StrelkaAOS : AosObjectBase
    
{
    [SerializeField] private Strelka _strelka;

    [AosEvent(name: "Игрок переводит стрелку в плюс")]
    public event AosEventHandler OnStrelkaMeasurePlus;
    [AosEvent(name: "Игрок переводит стрелку в минус")]
    public event AosEventHandler OnStrelkaMeasureMinus;

    [AosAction("Задать состояние точки true +, false -")]
    public void SetStrelkaPosition([AosParameter("Направление перевода")] bool position)
    {
        _strelka.SetCondition(position);
    }
public void TrySwitchStrelka(bool value)
    {
        if (value)
        {
            OnStrelkaMeasurePlus?.Invoke();
         
        }
        else
        { OnStrelkaMeasureMinus?.Invoke();
        
        }
    }

}
