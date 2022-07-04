using System.Collections;
using AosSdk.Core.Interaction.Interfaces;
using AosSdk.Core.Utils;
using UnityEngine;
using UnityEngine.Events;

[AosObject(name: "Стрелка")]

public class StrelkaAOS : AosObjectBase
    
{
    [SerializeField] private Strelka _strelka;

    [AosAction("Задать состояние точки true +, false -")]
    public void SetStrelkaPosition([AosParameter("Направление перевода")] bool position)
    {
        _strelka.SetCondition(position);
    }


}
