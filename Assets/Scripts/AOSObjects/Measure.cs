using System.Collections;
using AosSdk.Core.Interaction.Interfaces;
using AosSdk.Core.Utils;
using UnityEngine;
using UnityEngine.Events;

[AosObject(name: "Текст измерений")]
public class Measure : AosObjectBase
{
    [SerializeField] private CanvasController _canvasController;
    [AosAction(name: "Задать текст измерения")]
    public void SetMeasureText(string text)
    {
        _canvasController.SetMeasureText(text);
    }


}
