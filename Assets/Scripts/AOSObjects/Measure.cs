using System.Collections;
using AosSdk.Core.Interfaces;
using AosSdk.Core.Utils;
using UnityEngine;
using UnityEngine.Events;

[AosObject(name: "Текст измерений")]
public class Measure : AosObjectBase
{
    [SerializeField] private PlayerCanvasController _playerCanvasController;
    [AosAction(name: "Задать текст измерения")]
    public void SetMeasureText(string text)
    {
        //_playerCanvasController.SetMeasureText(text);
    }
    [AosAction("Включить Выключить окно измерения")]
    public void EnablaMeasureIcon([AosParameter("Отображение")] bool value)
    {
      //  _playerCanvasController.MeasureIconEnabler(value);
    }

}
