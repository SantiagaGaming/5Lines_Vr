using System.Collections;
using AosSdk.Core.Interaction.Interfaces;
using AosSdk.Core.Utils;
using UnityEngine;
using UnityEngine.Events;
[AosObject(name: "OutLineObject")]

public class OutLineObject : AosObjectBase
{
    private void Awake()
    {
        OutlineController _outlineController = FindObjectOfType<OutlineController>();
        _outlineController.AddOutlineObject(this);
    }

}
