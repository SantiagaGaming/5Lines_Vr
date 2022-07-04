using System.Collections;
using AosSdk.Core.Interaction.Interfaces;
using AosSdk.Core.Utils;
using UnityEngine;
using UnityEngine.Events;

[AosObject(name: "�������")]

public class StrelkaAOS : AosObjectBase
    
{
    [SerializeField] private Strelka _strelka;

    [AosAction("������ ��������� ����� true +, false -")]
    public void SetStrelkaPosition([AosParameter("����������� ��������")] bool position)
    {
        _strelka.SetCondition(position);
    }


}
