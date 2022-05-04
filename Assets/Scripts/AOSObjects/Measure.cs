using System.Collections;
using AosSdk.Core.Interaction.Interfaces;
using AosSdk.Core.Utils;
using UnityEngine;
using UnityEngine.Events;

[AosObject(name: "����� ���������")]
public class Measure : AosObjectBase
{
    [SerializeField] private CanvasController _canvasController;
    [AosAction(name: "������ ����� ���������")]
    public void SetMeasureText(string text)
    {
        _canvasController.SetMeasureText(text);
    }


}
