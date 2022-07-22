using System.Collections;
using AosSdk.Core.Interaction.Interfaces;
using AosSdk.Core.Utils;
using UnityEngine;
using UnityEngine.Events;
[AosObject(name: "String Changer")]
[RequireComponent(typeof(ObjectWithButton))]
public class StringChanger : AosObjectBase
{
    private ObjectWithButton _objWithButton;
    private void Start()
    {
        _objWithButton = GetComponent<ObjectWithButton>();
    }
    [AosAction("������ ��� �������")]
    public void SetObjectName([AosParameter("������ �����")] string text)
    {
        _objWithButton.SetHelperName(text);
    }
}
