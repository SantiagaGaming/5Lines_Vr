using System.Collections;
using AosSdk.Core.Interfaces;
using AosSdk.Core.Utils;
using AosSdk.Core.Player;
using AosSdk.Core.Player.Pointer;
using UnityEngine;
using UnityEngine.Events;
public class BackButtonObject : BaseButtton
{
    public UnityAction BackButtonClickEvent;
    public override void OnClicked(InteractHand interactHand)
    {
        BackButtonClickEvent?.Invoke();
    }
}
