using System.Collections;
using AosSdk.Core.Interfaces;
using AosSdk.Core.Utils;
using AosSdk.Core.Player;
using AosSdk.Core.Player.Pointer;
using UnityEngine;
using UnityEngine.Events;
public class MeasureButton : BaseButtton
{
    public UnityAction<Transform, string> MeasureButtonClickEvent;

    public override void OnClicked(InteractHand interactHand)
    {
        MeasureButtonClickEvent?.Invoke(transform, gameObject.name);
    }


}