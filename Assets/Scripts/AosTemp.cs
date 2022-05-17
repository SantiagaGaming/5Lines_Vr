using System.Collections;
using AosSdk.Core.Interaction.Interfaces;
using AosSdk.Core.Utils;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

[AosObject(name: "Temp text")]
public class AosTemp : AosObjectBase
{
    [SerializeField] private TextMeshProUGUI _textMesh;
    [AosAction(name: "������ ����� ���������")]
    public void SetTempText(string text)
    {
        
        _textMesh.text = HtmlToText.Instance.HTMLToTextReplace(text);
    }
}