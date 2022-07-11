using AosSdk.Core.Interaction.Interfaces;
using AosSdk.Core.Utils;
using UnityEngine;
using UnityEngine.Events;
using TMPro;
[AosObject(name: "���������")]
public class SetOtkazAOSObject : AosObjectBase
{
    [SerializeField] private TextMeshProUGUI _textMesh;
    [AosAction("������ ����� ������")]
    public void SetOtkazText([AosParameter("������ �����")] string text)
    {
        _textMesh.text = text;
    }

}
