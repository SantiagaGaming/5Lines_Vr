using System.Collections;
using AosSdk.Core.Interfaces;
using AosSdk.Core.Utils;
using AosSdk.Core.Player;
using AosSdk.Core.Player.Pointer;
using UnityEngine;
using UnityEngine.Events;
public class StrelkaButton : BaseButtton
{
    [SerializeField] private bool _plus;

    public UnityAction <bool> StrelkaButtonClickEvent;
    public override void OnClicked(InteractHand interactHand)
    {
        StrelkaButtonClickEvent?.Invoke(_plus);
    }
}
